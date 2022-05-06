import Vue from "vue";
import VueRouter from "vue-router";
import LoginForm from "../views/LoginForm.vue";
import TestLogin from "../views/TestLogin.vue";

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
    path: "/about-us",
    name: "about-us",
    component: () => import( '../views/AboutUS'),
  },
  {
    path: "/testLogin",
    name: "testLogin",
    component: TestLogin,
  },
  {
    path: "/homepage",
    name: "homepage",
    component: () =>import( "../views/HomePage.vue"),
  },
  {
    path: "/packages",
    name: "packages",
    component: () =>import( "../views/packages/ListingPackages.vue"),
  },
  {
    path: '/header-view',
    name: 'header-view',
    component: () => import( '@/views/Header.vue')
  },
 
]
   


const router = new VueRouter({
  mode: "history",
  base: process.env.BASE_URL,
  routes,
});

export default router;
