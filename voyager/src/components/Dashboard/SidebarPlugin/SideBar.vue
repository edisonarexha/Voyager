<template>
  <div
    class="sidebar"
  >
<el-row class="tac">
  <el-col >
    <div class="sidebar-header" @click="goTo('dashboard-view')">
     <img src="@/assets/dashboard-logo.svg" style="color:#909399">
    <h5>Voyager Dashboard</h5>
    </div>
    <el-menu
      default-active="2"
      class="el-menu-vertical-demo"
      @open="handleOpen"
      @close="handleClose">
      
      <el-menu-item index="2" @click="goTo('dashboard-view')">
        <i class="el-icon-pie-chart"></i>
        <span>Dashboard</span>
      </el-menu-item>
      <el-menu-item index="3" @click="goTo('rooms-view')">
        <i class="el-icon-s-ticket"></i>
        <span>Rooms</span>
      </el-menu-item>
      <el-menu-item index="4" @click="goTo('payments-view')">
        <i class="el-icon-s-opportunity
"></i>
        <span>Payments</span>
      </el-menu-item>
      <el-menu-item index="5" @click="goTo('users-view')">
       <i class="el-icon-user

"></i>
        <span>Users</span>
      </el-menu-item>
      <el-menu-item index="6" @click="goTo('trips-view')">
        <i class="el-icon-location-information

"></i>
        <span>Packages</span>
      </el-menu-item>
      <el-menu-item index="7" @click="goTo('hotel-news-site')">
        <i class="el-icon-office-building
"></i>
        <span>Hotels</span>
      </el-menu-item>
      <el-menu-item index="7" @click="goTo('about-us-manage')">
        <i class="el-icon-office-building
"></i>
        <span>About Us</span>
      </el-menu-item>
      <el-menu-item index="7" @click="goTo('contact-us-manage')">
        <i class="el-icon-office-building
"></i>
        <span>Contact Us</span>
      </el-menu-item>
    </el-menu>
  </el-col>
</el-row>
  </div>
</template>
<script>
 export default {
   data(){
     return{
       dashboard_details: true
     }
   },
    methods: {
      goTo(routeName) {
      this.$router.push({ name: routeName });
    },
      handleOpen(key, keyPath) {
        console.log(key, keyPath);
      },
      handleClose(key, keyPath) {
        console.log(key, keyPath);
      }
    }
  }
</script>
<style scoped>
@media screen and (min-width: 991px) {
  .nav-mobile-menu {
    display: none;
  }
}
.sidebar{
  width: 16%;
  /* height: 100%; */
background-color: #363740;
color: white;
}
.sidebar-header{
  display: flex;
  align-items: center;
  gap: 10px;
  margin: 10px;
}
::v-deep .el-menu{
  background-color: #363740;
}
::v-deep .el-menu-item{
 color: white;
 }
::v-deep .el-menu-item:focus, .el-menu-item:hover{
 background-color: #ecf5ff5e;
 }
</style>
