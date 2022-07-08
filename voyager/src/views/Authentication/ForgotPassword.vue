<template>
  <div>
    <div class="main__div">
      <img class="login__image img-responsive" src="../../assets/view.png" />
      <div class="angle"></div>
      <div class="login__form">
        <b-form class="inside__form" @submit.prevent="resetPassword">
          <h3 class="text-center">Forgot Password</h3>
          <b-form-group class="mt-3">
            <b-form-input
              v-model="email"
              type="text"
              id="email"
              name="email"
              placeholder="Email"
            />
            <span class="text-danger" v-if="error">{{
              error ? error : ""
            }}</span>
          </b-form-group>
          <b-button
            class="mt-3"
            type="submit"
            :disabled="email.length ? false : true"
            style="height: 50px"
            variant="success"
            >Send</b-button
          >

          <p class="text-center mt-3">
            <a class="text-decoration-none" href="/">Back to login</a>
          </p>
        </b-form>
      </div>
    </div>
  </div>
</template>

<script>
import { getAuth, sendPasswordResetEmail } from "firebase/auth";
export default {
  data() {
    return {
      email: "",
      error: "",
    };
  },
  methods: {
    makeToast() {
      this.$toast.success(
        "If your account exists, you will receive a email",
        {
          position: "top-right",
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
        }
      );
    },
    makeFailToast() {
      this.$toast.error("Account does not exist!", {
        position: "top-right",
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
    async resetPassword(){
      await sendPasswordResetEmail(getAuth(), this.email)
        .then(() => {
          this.makeToast();
          this.email = "";
        })
        .catch((err) => {
          this.makeFailToast();
          this.email = "";
          console.log(err);
        });
    },
  },
};
</script>

<style scoped>
html,
body {
  margin: 0;
}
.angle {
  display: flex;
  position: absolute;
  background-color: #fff;
  transform: rotateZ(3deg);
  width: 60px;
  right: 550px;
}
.main__div {
  height: 100vh;
  display: flex;
}
.login__image {
  width: 60%;
  max-height: 100%;
  object-fit: cover;
  display: block;
}

.login__form {
  /* border: 1px solid red; */
  width: 30%;
  margin-left: 90px;
  display: flex;
  align-items: center;
}

.inside__form {
  width: 70%;
  /* border:1px solid black; */
  display: flex;
  flex-direction: column;
}

@media only screen and (max-width: 800px) {
  

  .login__form {
    width: 70%;
  }
  .login__image {
    width: 50%;
  }
}

@media only screen and (max-width: 1200px) and (min-width: 800px) {
  

  .login__form {
    width: 100%;
  }
  .login__image {
    width: 50%;
  }
}
</style>
