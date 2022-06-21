import Vue from "vue";
import VueRouter from "vue-router";
import LoginForm from "../views/LoginForm.vue";
import Contact from "../views/ContactUs.vue"
import UserProfile from "../views/profile/UserProfile.vue"
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
    component: () => import( "../views/ForgotPassword.vue"),
  },
]
   


const router = new VueRouter({
  mode: "history",
  base: process.env.BASE_URL,
  routes,
});

export default router;
