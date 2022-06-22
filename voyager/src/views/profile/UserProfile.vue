<template>
  <div>
    <HeaderView />
   <div class="main__div">
      <div class="main__pic">
        <img class="top__image" src="../../assets/profilePic2.jpg" />
      </div>


      <div class="profile__pic-div"> 
        <img class="profile__pic" src="../../assets/profilePic3.png" />
        <div class="profile-div__details">
          <h3>{{userData ? `${userData.name} ${userData.lastName}` : null}}</h3>
          <p class="mt-3">Traveller since 3 days ago</p>
          </div>
      </div>

      <div class="all__tabs  mt-5">
          <b-tabs nav-class="testClass" content-class="mt-5"  align="center">
    <b-tab title-item-class="testClass" title-link-class="testClass" title="Profile" active><ProfileTab /></b-tab>
    <b-tab title="Trips"><TripsTab /></b-tab>
    <b-tab title="Profile Data"><ProfileDataTab :user="userData" /></b-tab>
  </b-tabs>

   
  </div>


    </div>
    <FooterView />
  </div>
</template>

<script>
import HeaderView from "../Header.vue";
import FooterView from "../Footer.vue";
import ProfileTab from "./ProfileTab.vue";
import TripsTab from "./TripsTab.vue";
import ProfileDataTab from "./ProfileDataTab.vue";
import { getUser } from "../../sdk/users";
import {getUserData} from "../../utils/utils.js"
export default {
  data(){
    return{
      userData:{},
    }
  },
 components: {
    HeaderView,
    FooterView,
    ProfileTab,
    TripsTab,
    ProfileDataTab
  },
  async mounted() {
    const user = await getUserData()
    const userEmail = user.email
    const {data} = await getUser(userEmail)
    this.userData = data
  },
}
</script>

<style scoped>
.testClass{
  color:red;
  text-decoration:center;
}
.main__div {
  width: 100%;
  height: fit-content;
  margin-bottom:7%;
}
.main__pic {
  width: 100%;
  height: 640px;
}

.top__image {
  height: 100%;
  width: 100%;
  object-fit: fill;
}

.profile__pic{
  position:absolute;
  top:32%;
  left:5%;
   background-repeat: no-repeat;
}
.profile__pic-div{
  width:50%;
  height:160px;
  margin:0 auto;
  padding:25px;
}
.profile-div__details{
  color:#6E798C;
  font-family: -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Open Sans', 'Helvetica Neue', sans-serif;
}

.all__tabs{
  width:100%;
  height:650px;
}



.right__div{
  height:80%;
  width:50%;
  border:1px solid purple;   
}

@media only screen and (max-width: 800px) {
.profile__pic-div{
  width:100%;
  height:fit-content;
  margin-top:40%;
}

}
</style>