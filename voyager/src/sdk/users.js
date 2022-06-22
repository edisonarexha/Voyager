import request from "./request";

export async function getUser(email) {
  try {
        const response = await request
            .get(`/users/${email}`);
        return response
    } catch (err) {
        return console.log(err.name);
    }
}

export function createUser(user) {
  return request
    .post("/users", user)
    .then((response) => {
      return response
    })
    .catch((err) => console.log(err.name));
}

export async function updateUser(user) {
    try {
        const response = await request
            .put(`/users/${user.email}`, user);
        return response
    } catch (err) {
        return console.log(err.name);
    }
  }
