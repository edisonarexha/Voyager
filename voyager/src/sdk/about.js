import apiCaller from "./apiCaller.js";

export async function getAboutList() {
  const result = await apiCaller.get("about/list");
  return result.data;
}


export async function createAbout(about) {
  return await apiCaller
    .post("/about/create", about)
    .then((response) => {
      return response
    })
    .catch((err) => console.log(err.name));
}


export async function editAbout(about) {
  return await apiCaller
    .put("/about/update", about)
    .then((response) => {
      return response
    })
    .catch((err) => console.log(err.name));
}
