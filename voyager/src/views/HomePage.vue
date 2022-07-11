<template>
  <div>
    <div class="header__test">
      <HeaderTest />
    </div>

    <div class="main mt-5">
     
      <div class="main__destinations mt-5" style="">
        <div class="destinations__text">
        <h2>Popular Destinations</h2>
            <p>Best Travel Destinations</p>
        </div>
        <div class="all__destinations">
            <div class="single__destination__tokyo">
                <h3 class="single__destination-text">Tokyo</h3>
            </div>

            <div class="single__destination__paris">
                <h3 class="single__destination-text">Paris</h3>

            </div>

            <div class="single__destination__seoul">
                <h3 class="single__destination-text">Seoul</h3>

            </div>

            <div class="single__destination__london">
                <h3 class="single__destination-text">London</h3>

            </div>
        </div>
      </div>

      <div class="single__hotel mt-5">
        <div class="single__hotel-pic">
          <img src="@/assets/HomeRoom.jpg" />
        </div>

        <div class="single__hotel-details">
          <div class="single__hotel-top-details">
            <p class="city__hotel">LONDON</p>
            <p>3 Days Ago</p>
          </div>
          <div class="single__hotel-middle-details">
            <h3>Prince Hotel VIP Line Booking</h3>
            <p>
              "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do
              eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut
              enim ad minim veniam, quis nostrud exercitation ullamco laboris
              nisi ut aliquip ex ea commodo consequat. " Ut enim ad minim
              veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip
              ex ea commodo consequat. " Ut enim ad minim veniam, quis nostrud
              exercitation ullamco laboris nisi ut aliquip ex ea commodo
              consequat. " Ut enim ad minim veniam, quis nostrud exercitation
              ullamco laboris nisi ut aliquip ex ea commodo consequat. "
            </p>
          </div>

          <div class="single__hotel-bottom-details">
            <p class="bottom__details-hotel">Hotel Prince</p>
            <p @click="goToHotel()" class="bottom__details-book">
              Book Now<i class="el-icon-right"></i>
            </p>
          </div>
        </div>
      </div>

    </div>
    <FooterView class="mt-5" />
  </div>
</template>

<script>
import HeaderTest from '../views/HeaderHomepage.vue'
import FooterView from "../views/Footer.vue";
export default {
  components: {
    HeaderTest,
    FooterView,
  },
  methods: {
    goToHotel() {
      this.$router.push("details");
    },
  },
};
</script>



<style scoped>
@import url("https://fonts.googleapis.com/css2?family=Open+Sans&display=swap");
@import url("https://fonts.googleapis.com/css2?family=DM+Serif+Display&display=swap");

* {
  margin: 0;
}

.main {
  width: 100%;
  height: fit-content;
  /* outline: 1px solid green; */
}



/* .carousel .carousel-item {
  height: 600px;
}

.carousel-item img {
    position: absolute;
    object-fit:cover;
    height: 600px;
} */

.main__destinations {
  width: 75%;
  height: 550px;
  /* outline: 1px solid black; */
  margin: 0 auto;
  display:flex;
  flex-direction: column;
  justify-content: space-evenly;
  align-items: center;
}

.destinations__text{
    width:50%;
    height:100px;
    margin:0 auto;
    /* outline:1px solid red; */
    display: flex;
    flex-direction: column;
    align-content: center;
    align-items: center;
    justify-content: space-evenly;
        font-family: 'Open Sans', sans-serif;
}
.destinations__text h2{
    font-size:38px;
    font-weight:800;
}

.destinations__text p{
    letter-spacing: 2px;
    font-size:17px;
}

.all__destinations{
    width:99%;
    height:350px;
    /* outline:1px solid red; */
    display:flex;
    flex-direction: row;
    justify-content: space-between;
    align-items: center;
}

.single__destination__paris{
    width:22%;
    height:300px;
    border-radius:15px;
    background: url('@/assets/paris.jpg');
     background-repeat: no-repeat;
    background-size: cover;
}

.single__destination__tokyo{
    width:22%;
    height:300px;
    border-radius:15px;
    background: url('@/assets/tokyo.jpg');
     background-repeat: no-repeat;
    background-size: cover;
}

.single__destination__seoul{
    width:22%;
    height:300px;
    border-radius:15px;
    background: url('@/assets/seoul.jpg');
     background-repeat: no-repeat;
    background-size: cover;
}

.single__destination__london{
    width:22%;
    height:300px;
    border-radius:15px;
    background: url('@/assets/london.jpg');
     background-repeat: no-repeat;
    background-size: cover;
}

.single__destination-text{
    color:white;
    font-family: 'Open Sans', sans-serif;
    font-weight:600;
    height:97%;
    display:flex;
    align-items: end;
    margin-left:10px;
    letter-spacing: 1px;
}

/* .single__destination img{
    width:100%;
    height:100%;
    object-fit: cover;
    border-radius:15px;
} */

.single__hotel {
  width: 75%;
  height: 400px;
  /* outline: 1px solid black; */
  margin: 0 auto;
  display: flex;
  flex-direction: row;
  justify-content: space-between;
  align-items: center;
}

.single__hotel-pic {
  width: 32%;
  height: 100%;
  border-radius: 15px;
}

.single__hotel-pic img {
  width: 100%;
  height: 100%;
  object-fit: cover;
  border-top-left-radius: 100px;
  border-bottom-left-radius: 100px;
}

.single__hotel-details {
  width: 63%;
  height: 97%;
  /* outline:1px solid blue; */
  font-family: "Open Sans", sans-serif;
  display: flex;
  flex-direction: column;
  justify-content: space-between;
}

.single__hotel-top-details {
  width: 95%;
  margin: 0 auto;
  height: 35px;
  /* outline:1px solid green; */
  display: flex;
  justify-content: space-between;
}

.single__hotel-top-details p {
  font-size: 14px;
  color: #6e798c;
}

.city__hotel {
  font-weight: 600;
}

.single__hotel-middle-details {
  width: 95%;
  margin: 0 auto;
  height: 60%;
  /* outline:1px solid red; */
  display: flex;
  flex-direction: column;
  justify-content: space-evenly;
}

.single__hotel-middle-details p {
  font-family: "Open Sans", sans-serif;
  color: #6e798c;
  font-size: 15px;
}

.single__hotel-middle-details h3 {
  font-family: "DM Serif Display", serif;
}

.single__hotel-bottom-details {
  width: 95%;
  margin: 0 auto;
  height: 10%;
  /* outline:1px solid blue; */
  display: flex;
  flex-direction: row;
  justify-content: space-between;
  align-items: flex-end;
}

.bottom__details-hotel {
  color: #007ae9;
  font-family: "Open Sans", sans-serif;
  font-weight: 600;
}

.bottom__details-book {
  color: #007ae9;
  font-family: "Open Sans", sans-serif;
  cursor: pointer;
}

.bottom__details-book:hover {
  color: rgb(38, 123, 64);
}

/* HEADER */
.header__test {
  width: 100%;
  height: 950px;
  /* outline: 1px solid blue; */
  background: black;
  background: linear-gradient(rgba(0, 0, 0, 0.4), rgba(0, 0, 0, 0.4)),
    url("../assets/sant.avif");
    background-repeat: no-repeat;
    background-size: cover;
  opacity: 0.9;
  /* background-blend-mode: overlay; */
}


</style>
