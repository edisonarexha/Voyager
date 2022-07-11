import admin from "../services/firebase";

const checkIfAuthenticated = async (req, res, next) => {
  try {
    const { authToken } = req;
    const userInfo = await admin.auth().verifyIdToken(authToken);
    req.authId = userInfo.uid;
    next();
  } catch (error) {
    return res.status(401).json({
      error,
    });
  }
};

export default checkIfAuthenticated;
