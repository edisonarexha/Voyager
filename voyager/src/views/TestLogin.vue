<template>
    <div>
        <h1 v-if="user.data.email.includes('admin')">You're logged in as Admin : {{ user.data.email}}</h1>
        <h1 v-else>You're logged in as simple user : {{ user.data.email}}</h1>
        <b-button @click="logout">Logout</b-button>
        </div>

</template>



<script>
import { mapGetters } from "vuex";
import { getAuth } from "firebase/auth";
export default {
  methods:{
logout() {
      getAuth()
        .signOut()
        .then(() => {
          this.$router.replace("/");
        })
        .catch((err) => {
          console.log(err);
        });
    },
  },
 computed: {
    ...mapGetters({
      user: "user",
    }),
  },
}
</script>

<style>

</style>