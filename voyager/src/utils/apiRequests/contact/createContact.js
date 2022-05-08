import apiCaller from "../apiCaller.js";

const createContact = async (contactBody) => {
  const { data } = await apiCaller.post("contact/create", contactBody);

  return data;
};

export default createContact;
