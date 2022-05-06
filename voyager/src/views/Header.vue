<template>
  <div>
 
<div class="line"></div>
<el-menu
  :default-active="activeIndex2"
  class="el-menu-demo"
  mode="horizontal"
  background-color="white"
  text-color="black"
  active-text-color="graz">
  <div class="flexed">
  <el-menu-item index="1" @click="goToHome()">Voyager</el-menu-item>
  <el-menu-item index="2" @click="goToAboutUs()">About us</el-menu-item>
  <el-menu-item index="3" >Contact Us</el-menu-item>
  <el-submenu index="4">
    <template slot="title">Packages</template>
    <el-menu-item index="4-1">Family Pack</el-menu-item>
    <el-menu-item index="4-2">Business Pack</el-menu-item>
    <el-menu-item index="4-3">Single Pack</el-menu-item>
    <el-menu-item index="4-3">HoneyMoon Pack</el-menu-item>
  
  </el-submenu>
  </div>

  <div>

  <!-- <el-menu-item v-if="user" index="1"></el-menu-item> -->
  <el-button v-if="user.loggedIn === true" index="1" type="info" plain @click="logout()">Log Out</el-button>
  </div>
</el-menu>

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
 },
    methods: {
         goToHome() {
      this.$router.push({
        name: "homepage",
      });
    },
         goToAboutUs() {
      this.$router.push({
        name: "about-us",
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
        
    // checkUser() {
    //   if (this.user.data) {
    //     let arr = [2];
    //     arr = this.user.data.email.split("@");
    //     // this.name = arr[0];
    //   }
    // },
  },
//   mounted() {
//    this.checkUser();
//  },
  }
</script>

<style lang="scss" scoped>
.el-menu-demo{
  display: flex;
align-items: center;
justify-content: space-between;
}
.flexed{
  display: flex;
align-items: center;
}
</style>