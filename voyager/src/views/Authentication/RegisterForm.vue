<template>
  <div>
    <div class="main__div">
      <img class="login__image img-responsive" src="../../assets/view.png" />
       <div class="angle"></div>
      <div class="register__form">
        <b-form class="inside__form" @submit.prevent="createUser">
           <div v-if="errors.general" class="alert alert-danger" role="alert">
            {{ errors.general ? errors.general : "" }}
          </div>
          <h3 class="text-center">Register</h3>
          <b-form-group
            class="mt-3"
           >
            <b-form-input
            v-model="user.name"
              type="text"
              id="name"
              name="name"
              placeholder="Name"
            />
          </b-form-group>
          <b-form-group 
            class="mt-3"
          >
            <b-form-input
            v-model="user.lastName"
              type="text"
              id="lastName"
              name="lastName"
              placeholder="Last Name"
            />
          </b-form-group>
          <b-form-group 
            class="mt-3"
          >
            <b-form-input
            v-model="user.username"
              type="text"
              id="username"
              name="username"
              placeholder="Username"
            />
          </b-form-group>
          <b-form-group 
            class="mt-3"
          >
            <b-form-input
            v-model="user.email"
              type="text"
              id="email"
              name="email"
              placeholder="Email"
            />
              <span class="text-danger" v-if="errors.email">{{
              errors.email ? errors.email : ""
            }}</span>
          </b-form-group>
          <b-form-group 
            class="mt-3"
         >
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
          <b-button class="mt-3" type="submit" style="width:100px;" variant="primary">Register</b-button>
          <p style="width:100%;" class="mt-3">Already have an account? <a class="text-decoration-none" href="/">Go to sign in</a></p>
        </b-form>
      </div>
    </div>
  </div>
</template>

<script>
import { getAuth, signInWithEmailAndPassword }from "firebase/auth";
import apiCaller from "../../utils/apiRequests/apiCaller";
import {createUser} from '../../sdk/users'
export default {
  data(){
    return{
      user:{
        name:'',
        lastName:'',
        username:'',
        email:'',
        password:''
      },
      hasError:false,
      errors:{
        general:'',
        email:'',
        password:''
      }
    }
  },
  methods:{
    async createUserData(){
      const userData = {
        name: this.user.name,
        lastName: this.user.lastName,
        userName: this.user.username,
        email: this.user.email,
        packageId: 0,
      }
      await createUser(userData)
    },
     async loginUser(){
        try {
        await signInWithEmailAndPassword(
          getAuth(),
          this.user.email,
          this.user.password
        );
      } catch (err) {
        console.log(err.message)
      }
    },
    async createUser(){
      this.checkError()
      try{
        if(!this.hasError){
        await apiCaller.post("users/register", {
          email: this.user.email,
          password: this.user.password,
        });
        await this.createUserData()
        await this.loginUser()
          this.$router.push('/homepage')
        }
      } catch(error){
        this.errors.general = error.message
      }
    },
    checkError(){
            let validRegex =
        /^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$/;

        if(!this.user.name.trim().length || !this.user.lastName.trim().length
         || !this.user.username.trim().length || !this.user.email.trim().length ||
         !this.user.password.trim().length){
           this.hasError = true
           this.errors.general = "Please fill all your data"
           this.errors.email = ''
           this.errors.password = ''
           console.log('fdsfsdfs')
         }
         else if(this.user.name.trim().length && this.user.lastName.trim().length
         && this.user.username.trim().length && this.user.email.trim().length
         && this.user.password.trim().length){
          if(this.user.password.trim().length < 6 || !this.user.email.trim().match(validRegex)){
            if(this.user.password.trim().length < 6){
           this.hasError = true
           this.errors.password = 'Password must be more than 7 char'
           this.errors.general = ''
           this.errors.email = ''
           if(!this.user.email.trim().match(validRegex)){
           this.errors.email = 'Please type a valid email!'
           this.hasError = true
           }
         }
         else if(!this.user.email.trim().match(validRegex)){
           this.hasError = true
             this.errors.password = ''
           this.errors.general = ''
           this.errors.email = 'Please type a valid email!'
           if(this.user.password.trim().length < 6){
             this.errors.password = 'Password must be more than 7 char'
           this.hasError = true
           }
         }
          }
           else{
           this.hasError = false
           this.errors.email = ''
           this.errors.password = ''
           this.errors.general = ''
         }
         }
       
    }
  }
}
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
  transform: rotateZ(2deg);
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

.register__form {
  width:30%;
  margin-left: 90px;
  display: flex;
  align-items:center;
}

.inside__form {
    width:70%;
  display: flex;
  flex-direction: column;
}

@media only screen and (max-width: 800px) {
 .register__form{
     width:70%;
 }
 .login__image {
   width:50%;
}
}
@media only screen and (max-width: 1200px) and (min-width: 800px) {
  .login-remember__checkbox {
    display: flex;
    flex-direction: column;
  }

  .register__form {
    width: 100%;
  }
  .login__image {
    width: 50%;
  }
}
</style>