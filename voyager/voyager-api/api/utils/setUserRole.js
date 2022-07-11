import admin from "../services/firebase";

const db = admin.firestore();

export default function setUserRole(user, newClaims) {
  admin.auth().setCustomUserClaims(user.uid, newClaims);

  db.collection("roles").doc(user.uid).set({
    email: user.email,
    role: newClaims,
  });
}
