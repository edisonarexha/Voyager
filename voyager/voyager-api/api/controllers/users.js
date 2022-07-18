import admin from "../services/firebase";
import schema from "../validators/register";

const db = admin.firestore();

const userController = {
  register: async (req, res) => {
    const validationResult = schema.validate(req.body);
    if (validationResult.error) {
      return res.status(403).json({
        message: validationResult.error,
      });
    }
    const { email, password } = req.body;

    try {
      const user = await admin.auth().createUser({
        email,
        password,
      });

      if (user.email.includes("admin")) {
        const customClaims = { admin: true };
        admin.auth().setCustomUserClaims(user.uid, customClaims);
        await db.collection("roles").doc(user.uid).set({
          email: user.email,
          role: customClaims,
        });
      }
      return res.json(user);
    } catch (err) {
      return res.status(500).json();
    }
  },
};

export default userController;
