<template>
  <div>
<div class="line"></div>
<div class="flexed">
<div>
<img src="../assets/voyager.png" style="width:100px; margin-left: 10px; " @click="goToHome()">
</div>
<el-menu
  :default-active="activeIndex2"
  class="el-menu-demo"
  mode="horizontal"
  background-color="white"
  active-text-color="graz">
  <div class="flexed">
  <el-menu-item index="2" @click="goToAboutUs()">About us</el-menu-item>
  <el-menu-item index="3" @click="goToContact()" >Contact Us</el-menu-item>
  <el-menu-item index="3" @click="goToPackage()" >Packages</el-menu-item>
  </div>
</el-menu>
  <div style=" margin-right: 10px;">
  <el-dropdown>
  <span class="el-dropdown-link">
    {{user ? user.data.email : null}}<i class="el-icon-arrow-down el-icon--right"></i>
  </span>
  <el-dropdown-menu slot="dropdown">
    <el-dropdown-item @click.native="logout()">Logout</el-dropdown-item>
    <el-dropdown-item v-if="checkIfAdmin" @click.native="goToDashboard()">Dashboard</el-dropdown-item>
    <el-dropdown-item divided @click.native="goToUserProfile()">Profile</el-dropdown-item>
  </el-dropdown-menu>
</el-dropdown>
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
      goToPackage() {
      this.$router.push({
        name: "packages",
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
*{
  font-family:'Open Sans';
}
.el-menu.el-menu--horizontal{
  border:none;
}
.el-menu-demo{
  display: flex;
align-items: center;
justify-content: space-between;
}
.flexed{
  display: flex;
align-items: center;
justify-content: space-between;
cursor: pointer;
}

 .el-dropdown-link {
    cursor: pointer;
    color: #409EFF;
  }
  .el-icon-arrow-down {
    font-size: 12px;
    }
  ::v-deep .el-menu-item{
        color: #6E798C;
    font-family: 'Open Sans', sans-serif;
  }
  ::v-deep .el-submenu__title{
     color: #6E798C;
    font-family: 'Open Sans', sans-serif;
  }
</style>