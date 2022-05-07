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
  <el-menu-item index="3" @click="goToContact()" >Contact Us</el-menu-item>
  <el-submenu index="4">
    <template slot="title">Packages</template>
    <el-menu-item index="4-1">Family Pack</el-menu-item>
    <el-menu-item index="4-2">Business Pack</el-menu-item>
    <el-menu-item index="4-3">Single Pack</el-menu-item>
    <el-menu-item index="4-3">HoneyMoon Pack</el-menu-item>
  
  </el-submenu>
  </div>

  <div>
  <el-dropdown>
  <span class="el-dropdown-link">
    {{user.data.email}}<i class="el-icon-arrow-down el-icon--right"></i>
  </span>
  <el-dropdown-menu slot="dropdown">
    <el-dropdown-item @click.native="logout()">Logout</el-dropdown-item>
    <el-dropdown-item divided disabled>Profile</el-dropdown-item>
  </el-dropdown-menu>
</el-dropdown>
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
       goToContact() {
      this.$router.push({
        name: "contact",
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

 .el-dropdown-link {
    cursor: pointer;
    color: #409EFF;
  }
  .el-icon-arrow-down {
    font-size: 12px;
  }
</style>