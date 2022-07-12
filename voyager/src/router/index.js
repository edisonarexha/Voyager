import Vue from "vue";
import VueRouter from "vue-router";
import LoginForm from "../views/Authentication/LoginForm.vue";
import Contact from "../views/ContactUs.vue"
import UserProfile from "../views/profile/UserProfile.vue"
import About from "../views/About/AboutUS.vue"
import Homepage from "../views/HomePage.vue"
import NotFound from "../views/NotFound.vue"
import { onAuthStateChanged, getAuth } from "firebase/auth";
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
    meta: {
      isAuthenticated: true,
    },
  },
  {
    path: "/homepage",
    name: "homepage",
    component: Homepage,
    meta: {
      isAuthenticated: true,
    },
  },
  {
    path: "/packages",
    name: "packages",
    component: () =>import( "../views/packages/ListingPackages.vue"),
    meta: {
      isAuthenticated: true,
    },
  },
  {
    path: '/header-view',
    name: 'header-view',
    component: () => import( '@/views/Header.vue'),
    meta: {
      isAuthenticated: true,
    },
  },
  {
    path: '/footer-view',
    name: 'footer-view',
    component: () => import( '@/views/Footer.vue'),
    meta: {
      isAuthenticated: true,
    },
  },
  {
    path: "/contact",
    name: "contact",
    component: Contact,
    meta: {
      isAuthenticated: true,
    },
  },
  {
    path: "/details",
    name: "details",
    component: () => import( "../views/HotelDetails.vue"),
    meta: {
      isAuthenticated: true,
    },
  },
  {
    path: "/dashboard-layout",
    name: "dashboard-layout",
    component: () => import( "../views/Dashboard/DashboardLayout.vue"),
    meta: {
          isAdmin: true,
        },
  },
  {
    path: "/dashboard-view",
    name: "dashboard-view",
    component: () => import( "../views/Dashboard/DashboardView.vue"),
    meta: {
      isAdmin: true,
    },
  }, 
  {
    path: "/rooms-view",
    name: "rooms-view",
    component: () => import( "../views/Dashboard/RoomsView.vue"),
    meta: {
      isAdmin: true,
    },
  }, 
  {
    path: "/users-view",
    name: "users-view",
    component: () => import( "../views/Dashboard/UsersView.vue"),
    meta: {
      isAdmin: true,
    },
  }, 
  {
    path: "/payments-view",
    name: "payments-view",
    component: () => import( "../views/Dashboard/PaymentsView.vue"),
    meta: {
      isAdmin: true,
    },
  }, 
  {
    path: "/trips-view",
    name: "trips-view",
    component: () => import( "../views/Dashboard/TripsView.vue"),
    meta: {
      isAdmin: true,
    },
  }, 
  {
    path: "/hotelview",
    name: "hotelview",
    component: () => import( "../views/HotelView.vue"),
    
    meta: {
      isAdmin: true,
    },
  },
  {
    path: "/hotel-news-site",
    name: "hotel-news-site",
    component: () => import( "../views/Dashboard/HotelNewsSite"),
    meta: {
      isAdmin: true,
    },
  },
  {
    path: "/about-us-manage",
    name: "about-us-manage",
    component: () => import( "../views/Dashboard/AboutUsManage"),
    meta: {
      isAdmin: true,
    },
  },
  {
    path: "/userprofile",
    name: "userprofile",
    component: UserProfile,
    meta: {
      isAuthenticated: true,
    },
  },
  {
    path: "/singlePackage",
    name: "singlePackage",
    component: () => import( "../views/packages/singlePackage.vue"),
    meta: {
      isAdmin: true,
    },
  },
  {
    path: "/forgotPassword",
    name: "forgotPassword",
    component: () => import( "../views/Authentication/ForgotPassword.vue"),
  },
  {
    path :'*',
    component:NotFound,
    },
    {
      path: "/successPay",
      name: "successPay",
      component:  () => import( "../views/CheckOut/SuccessPay.vue"),

    },
    {
      path: "/errorPay",
      name: "errorPay",
      component: () => import( "../views/CheckOut/ErrorPay.vue"),
    },
    {
      path: "/checkout",
      name: "checkout",
      component:  () => import( "../views/CheckOut/checkOut.vue"),

    },
]
   


const router = new VueRouter({
  mode: "history",
  base: process.env.BASE_URL,
  routes,
});

router.beforeEach((to, from, next) => {
  onAuthStateChanged(getAuth(), async (user) => {
    const mustBeLoggedIn = (record) =>
      record.meta.isAuthenticated || record.meta.isAdmin;

    if (to.matched.some((record) => mustBeLoggedIn(record))) {
      if (!user) {
        next("/");
      } else {
        const tokenResult = await getAuth().currentUser.getIdTokenResult();
        const isAdmin = tokenResult.claims.admin;
        if (isAdmin && to.matched.some((record) => !record.meta.isAdmin)) {
          next("/dashboard-view");
        } else if (to.matched.some((record) => record.meta.isAdmin)) {
          if (!tokenResult.claims.admin) {
            next("/homepage");
          } else {
            next();
          }
        } else {
          next();
        }
      }
    } else {
      next();
    }
  });
});

export default router;
