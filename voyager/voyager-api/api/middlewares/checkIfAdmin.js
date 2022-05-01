import admin from "../services/firebase";

const checkIfAdmin = async (req, res, next) => {

    const { authToken } = req;

    try {
        const user = await admin.auth().verifyIdToken(authToken);
        if (user.admin) {
            req.authId = user.uid;
        } else {
            return res.status(401).json({
                message: 'Not an admin'
            })
        }
    } catch (err) {
        return res.status(401).json({
            message: 'Cannot verify right now'
        })
    }
   

    next();
}

export default checkIfAdmin;