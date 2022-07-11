<template>
  <div>
    <div class="main__div mt-5">
      <h2 class="main__title">Profile Data:</h2>
      <b-form class="profile__tab-form">
        <b-form-group
          style="margin-right: 5%"
          class="profile__tab-form-group"
          label="Name"
        >
          <b-input
            class="profile__tab-form-input"
            @input.native="updateSingleUser"
            debounce="1500"
            v-model="updateUsers.name"
          />
        </b-form-group>
        <b-form-group class="profile__tab-form-group" label="Last name">
          <b-input
            class="profile__tab-form-input"
            @input.native="updateSingleUser"
            v-model="updateUsers.lastName"
            value="White"
          />
        </b-form-group>
        <b-form-group
          style="margin-right: 5%;"
          class="profile__tab-form-group"
          label="Username"
        >
          <b-input
            v-model="updateUsers.userName"
            @input.native="updateSingleUser"
            class="profile__tab-form-input"
            value="joellWhite2"
          />
        </b-form-group>
        <b-form-group class="profile__tab-form-group" label="Email">
          <b-input
            disabled
            class="profile__tab-form-input"
            :value="updateUsers.email"
          />
        </b-form-group>
      </b-form>
    </div>
  </div>
</template>

<script>
import { getUser, updateUser } from "../../sdk/users";
import { getUserData } from "../../utils/utils.js";
import { debounce } from "lodash";
export default {
  props: {
    user: {
      type: Object,
      default: () => {},
    },
  },
  data() {
    return {
      updateUsers: this.user,
    };
  },
  async mounted() {
    const useri = await getUserData();
    const userEmail = useri.email;
    const { data } = await getUser(userEmail);
    this.updateUsers = data;
  },
  methods: {
    makeToast() {
      this.$toast.success("User Updated Succesfully", {
        position: "bottom-left",
        timeout: 3000,
        closeOnClick: true,
        pauseOnFocusLoss: true,
        pauseOnHover: true,
        draggable: true,
        draggablePercent: 0.6,
        showCloseButtonOnHover: false,
        hideProgressBar: true,
        closeButton: "button",
        icon: true,
        rtl: false,
      });
    },
    async updateSingleUser() {
      await updateUser(this.updateUsers);
      this.updateUsers = this.user;
      this.callToast()
    },
     callToast : debounce(function(){
        this.makeToast()
      }, 600)
  },
};
</script>

<style scoped>
.main__div {
  width: 70%;
  height: 300px;
  /* outline:1px solid red; */
  margin: 0 auto;
  font-family: Open Sans;
}

.main__title {
  color: #6e798c;
}

.profile__tab-form {
  width: 100%;
  height: 50%;
  display: flex;
  flex-wrap: wrap;
  margin: 0 auto;
  /* border:1px solid red; */
  margin-top: 3%;
}

.profile__tab-form-group {
  margin-top:3%;
  width: 47.5%;
  /* outline:1px solid red; */
}

.profile__tab-form-input {
  margin-top:15px;
  height: 60px;
  color: #6e798c;
}

@media only screen and (max-width: 800px) {
  .profile__tab-form {
    width: 100%;
    height: fit-content;
    display: flex;
    flex-direction: column;
    flex-wrap: wrap;
    margin: 0 auto;
    /* border:1px solid red; */
    margin-top: 3%;
  }

  .main__div{
    width:95%;
    margin:0 auto;
    height:fit-content;

  }

  /* .profile__tab-form-group{
    width:70%;
} */
}
</style>
