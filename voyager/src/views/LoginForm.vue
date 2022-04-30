<template>
  <div>
    <div class="main__div">
      <img class="login__image img-responsive" src="../assets/view.png" />
      <div class="login__form">
        <b-form class="inside__form">
          <div v-if="errors.general" class="alert alert-danger" role="alert">
            {{ errors.general ? errors.general : "" }}
          </div>
          <h3 class="text-center">Login to your account</h3>
          <b-form-group class="mt-3" label="Email" label-for="email">
            <b-form-input
              v-model="user.email"
              type="email"
              id="email"
              name="email"
              placeholder="Email"
            />
            <span class="text-danger" v-if="errors.email">{{
              errors.email ? errors.email : ""
            }}</span>
          </b-form-group>
          <b-form-group class="mt-3" label="Password" label-for="password">
            <b-form-input
              v-model="user.password"
              type="password"
              id="password"
              name="password"
              placeholder="Password"
            />
            <span class="text-danger" v-if="errors.password">{{
              errors.password ? errors.password : ""
            }}</span>
          </b-form-group>
          <div class="login-remember__checkbox mt-3">
            <b-form-group>
              <input class="form-check-input" type="checkbox" />
              <label style="margin-left: 5px">Remember Me</label>
            </b-form-group>
            <a class="text-decoration-none" href="">Forgot password?</a>
          </div>
          <b-button
            class="mt-3"
            style="height: 50px"
            @click="checkError()"
            variant="success"
            >Login</b-button
          >
          <b-button class="mt-3" style="height: 50px" variant="dark">
            <img src="../assets/googleIcon.svg" />
            <span style="margin-left: 5px" class="google-text__button"
              >Or sign-in with google</span
            ></b-button
          >
          <p class="text-center mt-5">
            Dont have an account?
            <a class="text-decoration-none" href="/register">Join free today</a>
          </p>
        </b-form>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  data() {
    return {
      user: {
        email: "",
        password: "",
      },
      hasError: false,
      errors: {
        email: "",
        password: "",
        general: "",
      },
    };
  },
  methods: {
    checkError() {
      let validRegex =
        /^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$/;
      if (!this.user.email.trim().length || !this.user.password.trim().length) {
        this.hasError = true;
        this.errors.general = "Please fill all your data!";
        this.errors.email = "";
        this.errors.password = "";
      } else if (
        this.user.email.trim().length &&
        this.user.password.trim().length
      ) {
        this.errors.general = "";
        if (
          this.user.password.trim().length < 7 ||
          !this.user.email.match(validRegex)
        ) {
          if (this.user.password.trim().length < 7) {
            this.hasError = true;
            this.errors.password = "Password must be more than 7 char!";
            this.errors.general = ''
           this.errors.email = ''
            if (!this.user.email.match(validRegex))
              this.errors.email = "Please type a valid email!";
            this.hasError = true;
          }

          if (!this.user.email.trim().match(validRegex)) {
            this.hasError = true;
            this.errors.password = ''
           this.errors.general = ''
            this.errors.email = "Please type a valid email!";
            if (this.user.password.trim().length < 7)
              this.errors.password = "Password must be more than 7 char!";
            this.hasError = true;
          }
        } else {
          this.hasError = false;
          this.errors.email = "";
          this.errors.password = "";
          this.errors.general = "";
        }
      }
    },
  },
};
</script>

<style scoped>
html,
body {
  margin: 0;
}
.main__div {
  height: 100vh;
  display: flex;
}
.login__image {
  width: 42%;
  max-height: 100%;
  object-fit: cover;
  display: block;
}

.login__form {
  /* border: 1px solid red; */
  width: 30%;
  margin-left: 35px;
  display: flex;
  align-items: center;
}

.inside__form {
  width: 70%;
  /* border:1px solid black; */
  display: flex;
  flex-direction: column;
}
.login-remember__checkbox {
  width: 100%;
  display: flex;
  justify-content: space-between;
}

@media only screen and (max-width: 800px) {
  .google-text__button {
    display: none;
  }
  .login-remember__checkbox {
    display: flex;
    flex-direction: column;
  }

  .login__form {
    width: 70%;
  }
  .login__image {
    width: 50%;
  }
}

@media only screen and (max-width: 1200px) and (min-width: 800px) {
  .login-remember__checkbox {
    display: flex;
    flex-direction: column;
  }

  .login__form {
    width: 100%;
  }
  .login__image {
    width: 50%;
  }
}
</style>
