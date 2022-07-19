<template>
  <div>
    <HeaderView />
    <div class="main__div">
      <div class="main__pic">
        <img  class="top__image" src="../assets/HomeRoom.jpg" />
      </div>

      <div class="details">

        <div class="left__div">

          <h2 class="left__div__h2">{{ list.hotelName }}</h2>
          <p class="left__div__p"> {{ list.hotelDesc }} </p>
          <stripe-checkout ref="checkoutRef" mode="payment" :pk="publishableKey" :line-items="lineItems"
            :success-url="successURL" :cancel-url="cancelUrl" @loading="v => loading = v">

          </stripe-checkout>
          <b-button class="left__div__button" @click="submit(list.hotelId)"> Claim this</b-button>
        </div>


        <div class="right__div">

          <h2 class="right__div__h2">$20-$450</h2>

          <div class="boxi">

            <div class="boxi__top">
              <div class="boxi__top__left">
                <h4 class="boxi__top__left-h4">CHECK-IN</h4>
                <el-date-picker v-model="checkIn" class="datePickerEl" :picker-options="datePickerOptions" type="date"
                  placeholder="Pick a day">
                </el-date-picker>
              </div>

              <div style="border:none;" class="boxi__top__left">
                <h4 class="boxi__top__left-h4">CHECKOUT</h4>
                <el-date-picker v-model="checkOut" class="datePickerEl" type="date" :picker-options="datePickerOptions"
                  placeholder="Pick a day">
                </el-date-picker>
              </div>



            </div>
            <div class="boxi__bottom-div">
              <h4 class="boxi__top__left-h4">For</h4>
              <el-dropdown>
                <span class="el-dropdown-link">
                  2 Guests<i class="el-icon-arrow-down el-icon--right"></i>
                </span>
                <el-dropdown-menu slot="dropdown">
                  <el-dropdown-item>1 Guests</el-dropdown-item>
                  <el-dropdown-item>3 Guests</el-dropdown-item>
                  <el-dropdown-item disabled>4 Guests</el-dropdown-item>
                </el-dropdown-menu>
              </el-dropdown>

            </div>


          </div>
          <!-- <br/>-->
          <!-- <div v-for="item in datasources" v-bind:key="item.Id">
            <div class="hotel_details_right row">
              <div class="hotel_details_picture col-md-2">
                imghere
              </div>
              <div class="hotel_details col-md-10">
                <div class="row">

                  <p class="titlefont">
                    {{ item.hotelName }}
                  </p>

                </div>

              </div>

            </div>
          </div> -->
        </div>



      </div>
    <div>
<div class="container">
  <div class="card" v-for="item in datasources" v-bind:key="item.Id">
    <div class="card-header">
      <img src="https://c0.wallpaperflare.com/preview/483/210/436/car-green-4x4-jeep.jpg" alt="rover" />
    </div>
    <div class="card-body" @click="sendToHotelDetails(item.hotelId)">
      <span class="tag tag-teal">Hotel</span>
      <br/>
      <h4>
      {{item.hotelName}}
      </h4>
      <p style="height:80px !important;overflow:auto">
        {{item.hotelDesc}}
      </p>
      <div class="user">
        <div class="user-info">
          <h6>{{item.hotelName}}</h6>
          <small>{{item.HotelPrice}}</small>
        </div>
      </div>
    </div>
  </div>
  </div>
    </div>
      <!-- </div>
       </div> -->
    </div>

    <FooterView class="mt-3" />
  </div>
</template>

<script>
import HeaderView from "./Header.vue";
import FooterView from "./Footer.vue";
import { StripeCheckout } from '@vue-stripe/vue-stripe'
import Vue from 'vue';
import axios from 'axios';
import VueAxios from 'vue-axios';
Vue.use(VueAxios, axios)
export default {
  components: {
    HeaderView,
    FooterView,
    StripeCheckout
  },
  mounted() {
    this.$route.params.id;
    console.log(this.$route.params.id);
    Vue.axios.get('https://localhost:44377/api/HotelDatas/' + this.$route.params.id).then((resp) => {
      this.list = resp.data;

      console.log('test', resp.data)
    });

    Vue.axios.post('https://localhost:44377/api/hoteldetailsAPI/').then((datasource) => {
      this.datasources = datasource.data
      console.log('datasource', datasource.data)
    });


  },
  data() {
    // this.publishableKey="pk_test_51LJzV4ICtllJLqls31DllGAWtoYUiMLk2JIDBe42CZIi7OXit6dpEyNz9EFcgBVvo0XcqzdghKkKOOFfYqeI9Jtz00jk35XT00"
    return {
      datasources: undefined,
      list: undefined,
      // loading:false,
      // lineItems:[
      //   {
      //     price:'price_1LJzcyICtllJLqlsjWcoKQdF',
      //     quantity:1
      //   }
      // ],

      // sucessURL:'http://localhost:8080/successPay',
      // cancelURL:'http://localhost:8080/errorPay',
      // checkIn:'',
      // checkOut:'',
      //    datePickerOptions: {
      //   disabledDate (date) {
      //     return date < new Date()
      //   }
      // },
    }
  },
  methods: {
    submit(id) {

      // console.log( " test " +this.$router.push({name:"checkout"}));
      // this.$router.push({ name: "checkout"})
      this.responseAvailable = false;
  this.$router.push({name: 'checkout', params: { id: id }})
      // fetch("https://localhost:44377/api/HotelDatas", {
      //   "method": "GET",

      // }).then(response => {
      //   if (response.ok) {
      //     return response.json();
      //   } else {
      //     alert("Server returned " + response.status + " : " + response.statusText);
      //   }
      // }).then(response => {
      //   this.result = response.body;
      //   this.responseAvailable = true;
      // }).catch(err => {
      //   console.log(err);
      // });


    },
    sendToHotelDetails(id){
        Vue.axios.get('https://localhost:44377/api/HotelDatas/' + id).then((resp) => {
      this.list = resp.data;
    });
    }
  }

};
</script>

<style scoped>
@import url("https://fonts.googleapis.com/css2?family=Open+Sans&display=swap");
@import url("https://fonts.googleapis.com/css2?family=DM+Serif+Display&display=swap");
@import url("https://fonts.googleapis.com/css2?family=Roboto&display=swap");
* {
  box-sizing: border-box;
}
body {
  display: flex;
  justify-content: center;
  align-items: center;
  margin: 0;
  background-color: #f7f8fc;
  font-family: "Roboto", sans-serif;
  color: #10182f;
}
.container {
  display: flex;
  width: 1040px;
  justify-content: space-evenly;
  flex-wrap: wrap;
}
.card {
  margin: 10px;
  background-color: #fff;
  border-radius: 10px;
 
  overflow: hidden;
  width: 300px;
}
.card-header img {
  width: 100%;
  height: 200px;
  object-fit: cover;
}
.card-body {
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: flex-start;
  padding: 20px;
  min-height: 250px;
}

.tag {
  background: #cccccc;
  border-radius: 50px;
  font-size: 12px;
  margin: 0;
  color: #fff;
  padding: 2px 10px;
  text-transform: uppercase;
  cursor: pointer;
}
.tag-teal {
  background-color: #47bcd4;
}
.tag-purple {
  background-color: #5e76bf;
}
.tag-pink {
  background-color: #cd5b9f;
}

.card-body p {
  font-size: 13px;
  margin: 0 0 40px;
}
.user {
  display: flex;
  margin-top: auto;
}

.user img {
  border-radius: 50%;
  width: 40px;
  height: 40px;
  margin-right: 10px;
}
.user-info h5 {
  margin: 0;
}
.user-info small {
  color: #545d7a;
}

.titlefont {
  padding: 20px;
  font-family: 'Open Sans', sans-serif;
  font-weight: 600
}

.hotel_details_right {
  height: 100px;

  border-radius: 20px;
  width: 90%;
  float: right;
  margin-right: 26px;

}

.el-dropdown-link {
  cursor: pointer;
  color: #6b7280;
}

.el-icon-arrow-down {
  /* margin-left:290px; */
  font-size: 14px;
}

.boxi__bottom-div {
  width: 100%;
  height: 70px;
  padding: 8px;
}

.datePickerEl {
  width: 80%;
  border: none !important;
}

.boxi__top__left {
  width: 50%;
  height: 100%;
  padding: 8px;
  border-right: 1px solid #d1d5db;
}

.boxi__top__left-h4 {
  font-size: 17px;
}

.boxi__top {
  width: 100%;
  height: 91px;
  border-bottom: 1px solid #d1d5db;
  display: flex;
}

.boxi {
  margin: 0 auto;
  margin-top: 10%;
  width: 90%;
  height: 165px;
  border: 1px solid #d1d5db;
  border-radius: 15px;
}

.main__div {
  width: 100%;
  height: fit-content;
}

.main__pic {
  width: 100%;
  height: 600px;
}

.top__image {
  height: 100%;
  width: 100%;
  object-fit: cover;
}

.details {
  margin: 0 auto;
  margin-top: 5%;
  width: 75%;
  height: fit-content;
  display: flex;
  justify-content: space-between;
}

.left__div {
  width: 42%;
  height: fit-content;
  display: flex;
  flex-direction: column;
}

.right__div {
  width: 40%;
  height: 500px;
}

.left__div__p {
  width: 95%;
  margin-top: 30px;
  color: #374A59;
  /* font-family: 'Open Sans'; */
  font-style: normal;
  font-weight: 400;
  font-size: 14px;
  margin-left: 10px;
}

.left__div__button {
  background-color: #6E41E2;
  width: 25%;
  height: 10%;
  margin-top: 30%;
}

.left__div__h2 {
  width: fit-content;
  font-size: 40px;
  font-family: 'DM Serif Display';
}

.right__div__h2 {
  font-size: 40px;
  font-family: 'DM Serif Display';
  text-align: center;
}


@media only screen and (max-width: 800px) {
  .details {
    display: flex;
    flex-direction: column;
  }

  .left__div {
    width: 100%;
    height: fit-content;
  }

  .right__div {
    width: 100%;
    height: fit-content;
  }

  .boxi {
    width: 100%;
  }


}
</style>
