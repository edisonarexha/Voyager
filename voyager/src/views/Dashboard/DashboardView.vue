<template>
  <div class="dashboard">
    <side-bar :sidebar-item-color="sidebarBackground"></side-bar>
    <div style="max-width: 80%;" class="form-max-width">
       <div class="flexed" style="margin-bottom:20px">
      <h4>Voyager Dashboard</h4>
      <el-dropdown>
  <span class="el-dropdown-link">
    {{user ? user.data.email : null}}<i class="el-icon-arrow-down el-icon--right"></i>
  </span>
  <el-dropdown-menu slot="dropdown">
    <el-dropdown-item @click.native="goToHome()">Homepage</el-dropdown-item>
    <el-dropdown-item divided @click.native="goToUserProfile()">Profile</el-dropdown-item>
    <el-dropdown-item @click.native="logout()">Logout</el-dropdown-item>
  </el-dropdown-menu>
</el-dropdown>
    </div>
      <metrics-view class="metrics" :metrics="metrics" />
    <div class="second-container">
      <div class="report-table">
      <div class="flexed">
        <div>
          <h5>Latest Report</h5>
      <span style="font-size:10px">Group: User</span>
        </div>
       
      <h6 style="color:#3751FF"> Room Number:</h6>
      </div>
     
      <el-table :data="tableData" style="width: 100%;" >
        <el-table-column prop="date"  width="500">
        </el-table-column>
        <el-table-column prop="name"  width="500">
        </el-table-column>
      </el-table>
    </div>
    <div class="reviews">
      <div class="item" style=" border-bottom: 1px solid #00000021;">
      <span>Total Guests</span>
      <h5>515</h5>
      </div>
      <div class="item" style=" border-bottom: 1px solid #00000021;">
         <span>Total payment</span>
      <h5>$2500</h5>
      </div>
      <div class="item">
         <span>Stars Review</span>
      <h5>5 Stars</h5>
      </div>
     
    </div>
    </div>
    <div class="third-container">
      <div class="report-table">
      <div class="flexed">
        <div>
      <span style="font-size:15px">Showing 4 of <span class="bold" style="font-size:15px">400</span> results</span>
        </div>
      </div>
     
      <el-table :data="tableDashboard" style="width: 100%;" >
        <el-table-column prop="header" label="Header" width="100">
          <el-switch></el-switch>
        </el-table-column>
        <el-table-column prop="name" label="Name"  width="200">
        </el-table-column>
        <el-table-column prop="spend" label="Spend"  width="200">
        </el-table-column>
        <el-table-column prop="clicks" label="Clicks"  width="200">
        </el-table-column>
      </el-table>
    </div>
    </div>
    </div>
   
    
  </div>
</template>

<script>
import { getAuth } from "@firebase/auth";
import MetricsView from "@/views/MetricsView.vue";
import SideBar from '@/components/Dashboard/SidebarPlugin/SideBar.vue';
import { mapGetters } from 'vuex';
export default {
  name: "dashboard-view",
  components: { MetricsView, SideBar },
  data() {
    return {
      tableData: [
        {
          date: "Room check in not right",
          name: "250A",
        },
        {
          date: "Missing Money on isle",
          name: "50B",
        },
        {
          date: "Awaiting Clime fix",
          name: "20X",
        },
        {
          date: "Check out problems",
          name: "000",
        },
      ],
      tableDashboard: [
        {
          
          name: "DT-Brand-campaign",
          spend: "$175.22",
          clicks: "1234",
        },
        {
          name: "new_offer_8735",
          spend: "$175.22",
          clicks: "2000",
        },
        {
          name: "spring_2020",
          spend: "$175.22",
          clicks: "1239",
        },
        {
          name: "UK_brand_DT_campaign",
          spend: "$175.22",
          clicks: "100",
        },
      ],
      metrics: {
        guests: 45,
        checkIn: 16,
        checkingOut: 3,
        payCheck: 500,
      },
    };
  },
  computed:{
    ...mapGetters({
      user: "user",
    }),
  },
  methods:{
    goToHome() {
      this.$router.push({
        name: "homepage",
      });
    },
    logout() {
      getAuth()
        .signOut()
        .then(() => {
          this.$router.push({
        name: "login",
      });
        })
        .catch((err) => {
          console.log(err);
        });
    },
    
  }
};
</script>

<style scoped>
.dashboard {
  /* padding: 20px; */
  display: flex;
  
}
.report-table {
  border: 1px solid #00000021;
  border-radius: 8px;
  width: 45%;
  padding: 10px;
  margin: 15px;
}
.report-table span {
  font-style: normal;
  font-size: 10px;
  line-height: 24px;
  letter-spacing: 0.4px;
  color: #606061;
}
.flexed{
  display: flex;
  justify-content: space-between;
  align-items: center;
}
.second-container{
  display: flex;
}
.reviews{
  border: 1px solid #00000021;
  border-radius: 8px;
  width: 45%;
  padding: 10px;
  margin: 15px;
}
.item{
  display: flex;
  flex-direction: column;
  align-items: center;
  padding: 30px;
}
.reviews span {
  font-style: normal;
  font-size: 20px;
  line-height: 24px;
  letter-spacing: 0.4px;
  color: #606061;
}
.bold{
  font-weight: bold;
  color: black;
}
.form-max-width{
  max-width: 80%;
  padding: 20px;
}

.el-dropdown-link, .el-dropdown-selfdefine{
    background:rgb(55, 81, 255);
    padding:20px;
    border-radius:20px;
    color:#ececec;
    font-size:17px;
}
</style>
