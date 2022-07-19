<template>
  <div>
    <HeaderView />
    <div class="main__div">
      <div class="all__packages">
        <div class="div__single-package" v-for="item in list" v-bind:key="item.id">
          <div class="div-package__image">
            <img class="package__image" src="../../assets/honeyMoonPack.png" />
          </div>
          <div class="details">
            <div class="div__first-details">
              <p>Travel Packages</p>
              <p>17 days ago</p>
            </div>
            <div class="div__second-details">
              <h4 class="second-details__h3">{{item.packageName}}</h4>
              <!-- <p class="second-details__p">
              
              </p> -->
            </div>
            <div class="div__last-details">
              <a style="font-weight:600;" href="#">Voyager</a>
              <a style="font-weight:400, Regular" href="/singlePackage" @click="claimthis(item.id)">Claim this &#x2192;</a>
            </div>
          </div>
        </div>


      </div>
    </div>
    <FooterView />
  </div>
</template>

<script>
import HeaderView from '../../views/Header.vue'
import FooterView from "../../views/Footer.vue";
import Vue from 'vue';
import axios from 'axios';
Vue.use(axios)
export default {
  components: {
    HeaderView,
    FooterView,
  },
   data()
  {
    return {
      list:undefined
      }
  },
  mounted(){
        
      axios.get('https://localhost:44377/api/PackagesDatas').then((resp)=>{
        this.list=resp.data;
        // console.warn(resp.data);
    })
  },
  methods: {
    redirectToHomePage() {
      this.$router.push('/homepage')
    }
  }
}
</script>


<style scoped>
* {
  font-family: sans-serif;
}

html,
body {
  background-color: rgb(236, 236, 236);
  margin: 0;
}

.main__div {
  width: 100%;
  height: fit-content;
  background-color: rgb(236, 236, 236)
}

.all__packages {
  width: 100%;
  height: fit-content;
  display: flex;
  flex-direction: row;
  flex-wrap: wrap;
  justify-content: space-evenly;
  align-items: center;
  /* border: 1px solid red; */
}

.div__single-package {
  border-radius: 15px;
  width: 21%;
  height: 450px;
  background-color: white;
  margin-top: 3%;
  margin-bottom: 2%;
}

.package__image {
  height: 100%;
  width: 100%;
  object-fit: cover;
  border-top-left-radius: 15px;
  border-top-right-radius: 15px;
}

.div-package__image {
  width: 100%;
  height: 45%;
}

.div__first-details {
  margin-top: 6px;
  width: 100%;
  height: 15%;
  display: flex;
  justify-content: space-between;
}

.div__first-details p {
  margin-top: 7px;
  color: #6e798c;
  font-style: normal;
  font-size: 13px;
  line-height: 15px;
}

.details {
  width: 90%;
  height: 55%;
  margin: 0 auto;
}

.div__second-details {
  width: 100%;
  height: 65%;
  outline: red;
}

.second-details__h3 {
  color: #081F32;
  font-size: 20px;
  font-weight: 600;
}

.second-details__p {
  margin-top: 15px;
  color: #374A59;
  font-size: 14px;
}

.div__last-details {
  margin: 0 auto;
  width: 80%;
  height: 13%;
  display: flex;
  justify-content: space-between;
}

.div__last-details a {
  text-decoration: none;
  font-size: 13px;
}

@media only screen and (max-width: 800px) {
  .all__packages {
    display: flex;
    flex-direction: column;
    width: fit-content;
    height: fit-content;
  }

  .div__single-package {
    width: fit-content;
    height: fit-content;
    margin-top: 10px;
  }
}
</style>
