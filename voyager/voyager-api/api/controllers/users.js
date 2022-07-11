import admin from "../services/firebase";
import schema from "../validators/register";
import setUserRole from "../utils/setUserRole";

const db = admin.firestore();

const userController = {
  register: async (req, res) => {
    const validationResult = schema.validate(req.body);

    if (validationResult.error) {
      return res.status(400).json({ error: validationResult.error });
    }

    const { email, password } = req.body;
    try {
      const user = await admin.auth().createUser({
        email,
        password,
      });

      admin.auth().setCustomUserClaims(user.uid, { admin: true });

      db.collection("roles")
        .doc(user.uid)
        .set({
          email: user.email,
          role: { admin: true },
        });

      if (user.email && user.email.includes("admin")) {
        setUserRole(user, { admin: true });
      }

     

      return res.json({ user });
    } catch (error) {
      return res.status(403).json({ error: error.message });
    }
  },
};

export default userController;
