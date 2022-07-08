import Vue from "vue";
import VueRouter from "vue-router";
import LoginForm from "../views/Authentication/LoginForm.vue";
import Contact from "../views/ContactUs.vue"
import UserProfile from "../views/profile/UserProfile.vue"
import About from "../views/About/AboutUS.vue"
import Homepage from "../views/HomePage.vue"
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
      import(/* webpackChunkName: "register" */ "../views/Authentication/RegisterForm"),
  },
  {
    path: "/about-us",
    name: "about-us",
    component: About,
  },
  {
    path: "/homepage",
    name: "homepage",
    component: Homepage,
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
  {
    path: '/footer-view',
    name: 'footer-view',
    component: () => import( '@/views/Footer.vue')
  },
  {
    path: "/contact",
    name: "contact",
    component: Contact,
  },
  {
    path: "/details",
    name: "details",
    component: () => import( "../views/DetailsView.vue"),
  },
  {
    path: "/dashboard-layout",
    name: "dashboard-layout",
    component: () => import( "../views/Dashboard/DashboardLayout.vue"),
  },
  {
    path: "/dashboard-view",
    name: "dashboard-view",
    component: () => import( "../views/Dashboard/DashboardView.vue"),
  }, 
  {
    path: "/rooms-view",
    name: "rooms-view",
    component: () => import( "../views/Dashboard/RoomsView.vue"),
  }, 
  {
    path: "/users-view",
    name: "users-view",
    component: () => import( "../views/Dashboard/UsersView.vue"),
  }, 
  {
    path: "/payments-view",
    name: "payments-view",
    component: () => import( "../views/Dashboard/PaymentsView.vue"),
  }, 
  {
    path: "/trips-view",
    name: "trips-view",
    component: () => import( "../views/Dashboard/TripsView.vue"),
  }, 
  {
    path: "/hotelview",
    name: "hotelview",
    component: () => import( "../views/HotelView.vue"),
  },
  {
    path: "/hotel-news-site",
    name: "hotel-news-site",
    component: () => import( "../views/Dashboard/HotelNewsSite"),
  },
  {
    path: "/about-us-manage",
    name: "about-us-manage",
    component: () => import( "../views/Dashboard/AboutUsManage"),
  },
  {
    path: "/userprofile",
    name: "userprofile",
    component: UserProfile
  },
  {
    path: "/singlePackage",
    name: "singlePackage",
    component: () => import( "../views/packages/singlePackage.vue"),
  },
  {
    path: "/forgotPassword",
    name: "forgotPassword",
    component: () => import( "../views/Authentication/ForgotPassword.vue"),
  },
]
   


const router = new VueRouter({
  mode: "history",
  base: process.env.BASE_URL,
  routes,
});

export default router;
