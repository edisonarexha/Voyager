import { getAuth } from "firebase/auth";
import apiCaller from "../apiCaller.js";

const getHotelsList = async () => {
  const token = await getAuth().currentUser.getIdToken();
  const result = await apiCaller.get("HotelDatas/list", {
    headers: {
      authorization: `Bearer ${token}`,
    },
  });
  return result.data;
};

export default getHotelsList;
