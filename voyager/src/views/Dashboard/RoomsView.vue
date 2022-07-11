<template>
  <div class="rooms">
      <side-bar :sidebar-item-color="sidebarBackground"></side-bar>
      <div class="form-max-width">
          <h4>Voyager Dashboard</h4>
    <div class="header">
     <div class="flexed" style="gap:1050px">
            <h6 style="font-size: 20px">Rooms</h6>
            <el-button type="primary" @click="dialogFormVisible = true"
              >Add a Room</el-button
            >
          </div>
    </div>
    <div class="flexed">
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
    <div>
  <apex-chart width="500" type="area" :options="options" :series="series"></apex-chart>
</div>
    </div>
    
      </div>
    <div>
        <el-dialog :visible.sync="dialogFormVisible">
          <el-form :model="form">
            <div class="flexed">
              <el-form-item :label-width="formLabelWidth">
                <el-input
                  v-model="form.name"
                  autocomplete="off"
                  placeholder="Hotel Name"
                  class="input"
                ></el-input>
              </el-form-item>
              <el-form-item :label-width="formLabelWidth">
                <el-input
                  v-model="form.name"
                  autocomplete="off"
                  placeholder="Place"
                  class="input"
                ></el-input>
              </el-form-item>
            </div>
            <div class="flexed">
              <el-form-item :label-width="formLabelWidth">
                <el-input
                  v-model="form.name"
                  autocomplete="off"
                  placeholder="Price"
                  class="input"
                ></el-input>
              </el-form-item>
              <el-form-item :label-width="formLabelWidth">
                <el-input
                  v-model="form.name"
                  autocomplete="off"
                  placeholder="Date"
                  class="input"
                ></el-input>
              </el-form-item>
            </div>
            <el-form-item :label-width="formLabelWidth">
              <el-input
                v-model="form.name"
                autocomplete="off"
                placeholder="Description"
                type="textarea"
                class="input"
                rows="5"
              ></el-input>
            </el-form-item>
          </el-form>
          <span slot="footer" class="dialog-footer">
            <el-button type="primary" @click="dialogFormVisible = false"
              >Add</el-button
            >
          </span>
        </el-dialog>
      </div>
  </div>
</template>

<script>
import SideBar from '@/components/Dashboard/SidebarPlugin/SideBar.vue'
export default {
  components: { SideBar },
data(){
  return{
    dialogFormVisible: false,
    options: {
        chart: {
          id: 'vuechart-example',
          height: 350,
          type: 'area'
        },
        // xaxis: {
        //   categories: [1991, 1992, 1993, 1994, 1995, 1996, 1997, 1998]
        // },
        stroke: {
          curve: 'smooth'
        },
        dataLabels: {
          enabled: false
        },
      },
      series: [{
        name: 'series-1',
        data: [30, 40, 45, 50, 49, 60, 70, 91]
      }],
    form: {
        name: "",
        region: "",
        date1: "",
        date2: "",
        delivery: false,
        type: [],
        resource: "",
        desc: "",
      },
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
  /* padding: 20px; */
   display: flex;
   height: 900px;
   overflow: hidden !important;
}
.form-max-width{
  max-width: 80%;
  padding: 20px;
}
.header{
  padding: 20px;
}
.report-table {
  border: 1px solid #00000021;
  border-radius: 8px;
  /* width: 45%; */
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
.flexed {
  display: flex;
}
.justify-between{
  justify-content: space-between;
}
</style>