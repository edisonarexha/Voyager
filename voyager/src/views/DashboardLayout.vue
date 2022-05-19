<template>
  <div>
    <side-bar
      :sidebar-item-color="sidebarBackground"
    >
    </side-bar>
  </div>
</template>

<script>
import SideBar from "../components/Dashboard/SidebarPlugin/SideBar.vue"
export default {
  components:{SideBar},
  data() {
    return {
      sidebarBackground: "green",
      // sidebarBackgroundImage: require("@/assets/HomeRoom.jpg"),
    };
  },

}
</script>

<style>

</style>