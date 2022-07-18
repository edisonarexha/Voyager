import request from './request'

// export  function getHotels(){
//     return request.get('/HotelDatas').then(response => {
//         return 
//     }).catch((err) => console.log(err.name))
// }
export async function getHotels() {
    try {
        const response = await request
            .get("/HotelDatas");
        return console.log("hotels" + response);
    } catch (err) {
        return console.log(err.name);
    }
  }
export function createHotel() {
    return request
      .post("/HotelDatas" )
      .then((response) => {
        return response
      })
      .catch((err) => console.log(err.name));
  }
  
  export async function updateHotel() {
      try {
          const response = await request
              .put(`/HotelDatas/`);
          return response
      } catch (err) {
          return console.log(err.name);
      }
  }
  
  export async function deleteHotel() {
      try {
          const response = await request
              .delete(`/HotelDatas/`);
          return response
      } catch (err) {
          return console.log(err.name);
      }
  }
  