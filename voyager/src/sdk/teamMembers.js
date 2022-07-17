import request from "./request";

export async function getAllTeamMembers() {
    try {
        const response = await request
            .get("/teamMembersDatas");
        return response;
    } catch (err) {
        return console.log(err.name);
    }
  }

// export async function getUser(email) {
//   try {
//         const response = await request
//             .get(`/users/${email}`);
//         return response
//     } catch (err) {
//         return console.log(err.name);
//     }
// }

export function createTeamMember(user) {
  return request
    .post("/teamMembersDatas", user)
    .then((response) => {
      return response
    })
    .catch((err) => console.log(err.name));
}

export async function updateTeamMember(user) {
    try {
        const response = await request
            .put(`/teamMembersDatas/${user.id}`, user);
        return response
    } catch (err) {
        return console.log(err.name);
    }
}

export async function deleteTeamMember(user) {
    try {
        const response = await request
            .delete(`/teamMembersDatas/${user.id}`, user);
        return response
    } catch (err) {
        return console.log(err.name);
    }
}
