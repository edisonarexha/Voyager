<template>
  <div class="rooms">
      <h4>Voyager Dashboard</h4>
    <div class="header">
      <h5>Room Table</h5>
    </div>
    <div class="third-container">
      <div class="report-table">
      <div class="flexed">
        <div>
      <span style="font-size:15px">Showing 8 of <span class="bold" style="font-size:15px">200</span> results</span>
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
</template>

<script>
export default {
data(){
  return{
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
        {
          name: "UK_brand_DT_campaign",
          spend: "$175.22",
          clicks: "100",
        },
        {
          name: "UK_brand_DT_campaign",
          spend: "$175.22",
          clicks: "100",
        },
        {
          name: "UK_brand_DT_campaign",
          spend: "$175.22",
          clicks: "100",
        },
        {
          name: "UK_brand_DT_campaign",
          spend: "$175.22",
          clicks: "100",
        },
      ],
  }
}
}
</script>

<style scoped>
.rooms{
  padding: 20px;
}
.header{
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
.bold{
  font-weight: bold;
  color: black;
}
</style>