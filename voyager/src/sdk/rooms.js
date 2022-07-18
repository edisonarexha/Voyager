import request from './request'

export async function getHotelRooms(){
    return request.get('/HotelRooms').then(response => {
        return console.log("hotels", response)
    }).catch((err) => console.log(err.name))
}

export function createHotelRoom() {
    return request
      .post("/HotelRooms" )
      .then((response) => {
        return response
      })
      .catch((err) => console.log(err.name));
  }
  
  export async function updateHotelRoom() {
      try {
          const response = await request
              .put(`/HotelRooms/`);
          return response
      } catch (err) {
          return console.log(err.name);
      }
  }
  
  export async function deleteHotelRoom() {
      try {
          const response = await request
              .delete(`/HotelRooms/`);
          return response
      } catch (err) {
          return console.log(err.name);
      }
  }
  