import apiCaller from "./apiCaller.js";

export async function getContact() {
  const result = await apiCaller.get("contact/list");
  return result.data;
}

export async function getDetails() {
    const result = await apiCaller.get("details/list");
    return result.data;
}

export async function createDetails(details) {
    return await apiCaller
      .post("/details/create", details)
      .then((response) => {
        return response
      })
      .catch((err) => console.log(err.name));
  }

  export async function editDetails(details) {
    return await apiCaller
      .put("/details/update", details)
      .then((response) => {
        return response
      })
      .catch((err) => console.log(err.name));
  }