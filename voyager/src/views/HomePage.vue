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
    <div v-for="item in list" v-bind:key="item.Id" >
      <div class="single__hotel mt-5" >
        <div class="single__hotel-pic">
          <img src="@/assets/HomeRoom.jpg" />
        </div>

        <div class="single__hotel-details">
          <div class="single__hotel-top-details">
            <!-- LONDON -->
            <p class="city__hotel">{{item.location}} {{item.address}}</p> 
            <p>3 Days Ago</p>
          </div>
          <div class="single__hotel-middle-details">
            <h3>{{item.hotelName}}</h3>
            <p>
             {{item.hotelDesc}}
            </p>
          </div>

          <div class="single__hotel-bottom-details">
            <p class="bottom__details-hotel">Hotel Prince</p>
            <p @click="goToHotel(item.hotelId)" class="bottom__details-book">
              Book Now<i class="el-icon-right"></i>
            </p>
          </div>
        </div>
      </div>
      </div>
<!-- <div v-for="item in list" v-bind:key="item.Id">
<p style="font-weight:bolder">
  {{item.hotelName}}
</p>
</div> -->
    </div>
    <FooterView class="mt-5" />
  </div>
</template>

<script>
import HeaderTest from '../views/HeaderHomepage.vue'
import FooterView from "../views/Footer.vue";
import Vue from 'vue';
import axios from 'axios';
import VueAxios from 'vue-axios';
Vue.use(VueAxios,axios)
export default {
  components: {
    HeaderTest,
    FooterView,
  },
  name:"HomePage",
  data()
  {
    return {
      list:undefined
      }
  },
  mounted(){
      Vue.axios.get('https://localhost:44377/api/HotelDatas').then((resp)=>{
        this.list=resp.data;
        // console.warn(resp.data);
    })
  },
  methods: {
    goToHotel(id) {
      
      this.$router.push({name: 'details', params: { id: id }})
      //  this.$router.push("details");
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

@media only screen and (max-width: 800px) {
.destinations__text{
  width:100%;
  }

.main__destinations{
    width:100%;
    height:fit-content;
  }

.all__destinations{
  display:flex;
  flex-direction: row;
  flex-wrap:wrap;
  height:fit-content;
}

.single__destination__london,.single__destination__paris,.single__destination__seoul,.single__destination__tokyo{
  width:45%;
  margin-top:5px;
}


.single__hotel{
  width:100%;
  height:fit-content;
  margin-top:100px;  
  display:flex;
  flex-direction: column;
  margin-bottom:10px;
}
.single__hotel-pic{
  width:100%;
  height:100%;
  border-radius:0;
}

.single__hotel-pic img{
  width:100%;
  height:100%;
  border:none;
  border-top-left-radius:0px;
  border-bottom-left-radius: 0px;
}

}


</style>
