import { getAuth } from "firebase/auth";
import apiCaller from "../apiCaller";

const deleteContact = async (id) => {
  const token = await getAuth().currentUser.getIdToken();
  return apiCaller.delete(`contact/delete/${id}`, {
    headers: { authorization: `Bearer ${token}` },
  });
};

export default deleteContact;
