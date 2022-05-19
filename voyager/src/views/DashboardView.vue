<template>
  <div class="dashboard">
    <div>
      <h4>Voyager Dashboard</h4>
      <metrics-view class="metrics" :metrics="metrics" />
    </div>
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
    
  </div>
</template>

<script>
// import SideBar from "../components/Dashboard/SidebarPlugin/SideBar.vue"
import MetricsView from "@/views/MetricsView.vue";
export default {
  name: "dashboard-view",
  components: { MetricsView },
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
      metrics: {
        guests: 45,
        checkIn: 16,
        checkingOut: 3,
        payCheck: 500,
      },
    };
  },
};
</script>

<style scoped>
.dashboard {
  padding: 20px;
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
</style>
