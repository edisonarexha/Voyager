<template>
  <div class="main__div">
    <div class="header__top-links">
       <img @click="goToHome()" src="../assets/logoWhite.png"  />
         <div class="middle__header mt-5">
             <a href="/homepage">Home </a>
             <a href="/about-us">About </a>
             <a href="/contact">Contact </a>
             <a href="/packages">Packages </a>
         </div>
       <el-dropdown>
  <span class="el-dropdown-link">
    {{user ? user.data.email : null}}<i class="el-icon-arrow-down el-icon--right"></i>
  </span>
  <el-dropdown-menu slot="dropdown">
    <el-dropdown-item v-if="checkIfAdmin" @click.native="goToDashboard()">Dashboard</el-dropdown-item>
    <el-dropdown-item v-if="!checkIfAdmin" divided @click.native="goToUserProfile()">Profile</el-dropdown-item>
    <el-dropdown-item @click.native="logout()">Logout</el-dropdown-item>
  </el-dropdown-menu>
</el-dropdown>



    </div>


    <div class="bottom__header" style="top:200px">
        <div class="bottom__header-top-text">
            <h3>Where do you want to go?</h3>
            <p>Fill this form and our manager will contact you</p>
        </div>

        <div class="bottom__header-bottom-inputs">
            <input class="icon-rtl" type="text" placeholder="Destination, city">
            <input class="icon-rtl-month" type="text" placeholder="Any Month">
            <input class="icon-rtl-range" type="text" placeholder="Any Range">
            <button class="inputs__button">Search</button>
        </div>
    </div>
  </div>
</template>

<script>
import { getAuth } from "@firebase/auth";
import { mapGetters } from 'vuex';
export default {
    name: 'HeaderView',
    data() {
      return {
        activeIndex: '1',
        activeIndex2: '1'
      };
    },
    computed: {
    ...mapGetters({
      user: "user",
    }),
    checkIfAdmin(){
      if(this.user && this.user.data.email.includes("admin")) return true
      return false
    }
 },
    methods: {
         goToHome() {
      this.$router.push({
        name: "homepage",
      });
    },
      
       goToUserProfile() {
      this.$router.push({
        name: "userprofile",
      });
    },
       goToDashboard() {
      this.$router.push({
        name: "dashboard-view",
      });
    },
    logout() {
      getAuth()
        .signOut()
        .then(() => {
          this.$router.push({
        name: "login",
      });
        })
        .catch((err) => {
          console.log(err);
        });
    },

  },

  }
</script>

<style lang="scss" scoped>
.main__div{
    height:100%;
    width:100%;
    display: flex;
    flex-direction: column;
}
.header__top-links {
  width: 100%;
  height: 80px;
  padding: 5px;
  /* outline:1px solid green; */
  // margin: 0 auto;
  display: flex;
  flex-direction: row;
  align-items: center;
  justify-content: space-between;
}

.header__top-links img {
  width: 100px;
  height: 20px;
  margin-left: 5px;
  margin-bottom: 5px;
  cursor:pointer;
}

// MIDDLE

.middle__header{
    width:40%;
    height:80px;
    margin:0 auto;
    display: flex;
    justify-content: space-evenly;
    align-content: center;
    text-align: center;
}

.middle__header a{
    text-decoration: none;
    color:#ececec;
    font-size: 17px;
    letter-spacing: 2px;
    font-family: 'Open Sans', sans-serif;
}

.middle__header a:hover{
    text-decoration: none !important;
    color:rgba(55, 82, 255, 0.575);
}

.bottom__header{
    width:90%;
    margin:0 auto;
    margin-top:5%;
    height:400px;
    // outline:1px solid white;
    display:flex;
    flex-direction: column;
    align-content: center;
    align-items: center;
    justify-content: space-evenly;
    position:sticky;
    top:0;
}

.bottom__header-top-text{
    width:50%;
    height:30%;
    // outline:1px solid red;
    color:#ffffff;
    display: flex;
    flex-direction: column;
    text-align: center;
    font-family: 'Open Sans', sans-serif;
    justify-content: end;
}

.bottom__header-top-text h3{
    font-size:52px;   
    font-weight: 600;  
}

.bottom__header-top-text p {
    margin:0;    
    font-size:17px;
    color:#ececec;
}

.bottom__header-bottom-inputs{
    width:85%;
    height:20%;
    // outline:1px solid white;
    display: flex;
    justify-content: space-between;
}

.bottom__header-bottom-inputs input{
    width:22%;
    height:75%;
    outline: none;
    font-size:20px;
    border:none;
    border-radius:5px;
    padding:22px;
    color:#838383;
}

.icon-rtl {
  padding-right: 35px;
  background: url("@/assets/icons/mbri-search.svg") no-repeat right;
  background-size: 30px;
  background-color:white;
}

.icon-rtl-month{
    padding-right: 35px;
  background: url("@/assets/icons/mbri-calendar.svg") no-repeat right;
  background-size: 30px;
  background-color:white;
}

.icon-rtl-range{
    padding-right: 35px;
  background: url("@/assets/icons/mbri-up-down.svg") no-repeat right;
  background-size: 30px;
  background-color:white;
}

.inputs__button{
    width:22%;
    height:75%;
  background:rgba(55, 82, 255, 0.575);
  color:white;
    border:none;
    border-radius:45px;
}


.el-dropdown-link, .el-dropdown-selfdefine{
    background:rgba(55, 82, 255, 0.575);
    padding:20px;
    border-radius:20px;
    color:#ececec;
    font-size:15px;
}
.el-dropdown-menu, .el-popper{
    width:11%;
    border-radius:15px;
}


</style>
