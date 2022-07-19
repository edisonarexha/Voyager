import request from './request'

export async function getPackages() {
    try {
        const response = await request
            .get("/PackageDatas");
        return response;
    } catch (err) {
        return console.log(err.name);
    }
  }
export function createPackages(packages) {
    return request
      .post("/PackageDatas", packages)
      .then((response) => {
        return response
      })
      .catch((err) => console.log(err.name));
  }
  
  export async function updatePackages(packages) {
      try {
          const response = await request
              .put(`/PackageDatas/${packages.id}`, packages);
          return response
      } catch (err) {
          return console.log(err.name);
      }
  }
  
  export async function deletePackages(packages) {
      try {
          const response = await request
              .delete(`/PackageDatas/${packages.id}`, packages);
          return response
      } catch (err) {
          return console.log(err.name);
      }
  }