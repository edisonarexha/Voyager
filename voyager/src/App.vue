<template>
  <div id="app">
    <HeaderView v-if="user.loggedIn === true"/>
    <router-view />
  </div>
</template>
  <script>
import { mapGetters } from 'vuex'
  import HeaderView from './views/Header.vue'

export default {
  name: 'App',
 components :{
   HeaderView
 },
 computed: {
      // ...mapState('users', {
      //   user: (state) => state.user
      // }),
    ...mapGetters({
      user: "user",
    }),
 },
 }
  </script>
<style scoped>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
}
</style>