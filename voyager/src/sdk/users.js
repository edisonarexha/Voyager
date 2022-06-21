import request from "./request";

export async function getUser(email) {
  try {
        const response = await request
            .get("/users/email", {
                params: {
                    email: email,
                },
            });
        return response;
    } catch (err) {
        return console.log(err.name);
    }
}

export function createUser(user) {
  return request
    .post("/users", {
        name: user.name,
        lastName: user.lastName,
        userName: user.userName,
        email: user.email,
        packageId: 0,
      
    })
    .then((response) => {
      return response;
    })
    .catch((err) => console.log(err.name));
}
