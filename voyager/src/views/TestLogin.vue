<template>
    <div>
        <h1 v-if="user.data.email.includes('admin')">You're logged in as Admin : {{ user.data.email}}</h1>
        <h1 v-else>You're logged in as simple user : {{ user.data.email}}</h1>
        </div>
</template>



<script>
import { mapGetters } from "vuex";
export default {
 computed: {
    ...mapGetters({
      user: "user",
    }),
  },
}
</script>

<style>

</style>