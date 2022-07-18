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
        return response;
    } catch (err) {
        return console.log(err.name);
    }
  }
export function createHotel(hotel) {
    return request
      .post("/HotelDatas", hotel)
      .then((response) => {
        return response
      })
      .catch((err) => console.log(err.name));
  }
  
  export async function updateHotel(hotel) {
      try {
          const response = await request
              .put(`/HotelDatas/${hotel.hotelId}`, hotel);
          return response
      } catch (err) {
          return console.log(err.name);
      }
  }
  
  export async function deleteHotel(hotel) {
      try {
          const response = await request
              .delete(`/HotelDatas/${hotel.hotelId}`, hotel);
          return response
      } catch (err) {
          return console.log(err.name);
      }
  }
  
   
//   handleFileSelected = (event) => {
//     event.preventDefault();
//     this.setState({Photo: event.target.files[0].name});
//     const formData = new FormData();
//     formData.append(
//         "myFile",
//         event.target.files[0],
//         event.target.files[0].name
//     );

//     fetch('http://localhost:5000/api/Laptops/SaveFile',{
//         method:'POST',
//         body:formData
//     })
//     .then(res=>res.json())
//     .then((result)=>{
//       console.log(result)
//     },
//     (error)=>{
//         alert('Failed');
//     })
//   }
