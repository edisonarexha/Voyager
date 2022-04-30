import Vue from "vue";
import VueRouter from "vue-router";
import LoginForm from "../views/LoginForm.vue";

Vue.use(VueRouter);

const routes = [
  {
    path: "/",
    name: "login",
    component: LoginForm,
  },
  {
    path: "/register",
    name: "register",
    component: () =>
      import(/* webpackChunkName: "register" */ "../views/RegisterForm"),
  },
  {
    path: "/contact-us",
    name: "contact-us",
    component: () => import( '../views/ContactUs'),
  },
];

const router = new VueRouter({
  mode: "history",
  base: process.env.BASE_URL,
  routes,
});

export default router;
