<template>
  <div class="rooms">
    <h4>Voyager Dashboard</h4>
    <div class="users-container">
      <div class="header">
        <h5>Users</h5>
      </div>
      <div>
        <div class="report-table">
          <div class="flexed" style="justify-content:end; gap:20px">
            <span style="font-size: 15px"> <list-icon size="1.5x" class="custom-class"></list-icon> Sort</span>
            <span style="font-size: 15px"> <filter-icon size="1.5x" class="custom-class"></filter-icon> Filter</span>
          </div>

          <el-table :data="tableDashboard">
            <el-table-column prop="user" label="Users" width="500">
              <div class="flexed" style="gap: 20px">
                <el-image
                  style="width: 100px; height: 100px; margin-top: 10px"
                  :src="url"
                  :preview-src-list="srcList"
                >
                </el-image>
                <div>
                  <h6>Tom Cruise</h6>
                  <span>joined 24.05.2019</span>
                </div>
              </div>
            </el-table-column>
            <el-table-column prop="name" label="User Name" width="300">
            </el-table-column>
            <el-table-column prop="spend" label="Date" width="300">
            </el-table-column>
            <el-table-column prop="clicks" label="Activity" width="300">
              <div class="activity">High</div>
            </el-table-column>
          </el-table>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import { FilterIcon, ListIcon } from 'vue-feather-icons'
export default {
   components: {
    FilterIcon, ListIcon
  },
  data() {
    return {
      url: "https://cdn.dribbble.com/users/2095589/screenshots/4166422/user_1.png",
      srcList: [
        "https://fuss10.elemecdn.com/8/27/f01c15bb73e1ef3793e64e6b7bbccjpeg.jpeg",
        "https://fuss10.elemecdn.com/1/8e/aeffeb4de74e2fde4bd74fc7b4486jpeg.jpeg",
      ],
      tableDashboard: [
        {
          user: "DT-Brand-campaign",
          name: "Tom Cruise",
          spend: "May 26, 2019",
          clicks: "High",
        },
        {
          user: "new_offer_8735",
          name: "Tom Cruise",
          spend: "May 26, 2019",
          clicks: "High",
        },
        {
          user: "spring_2020",
          name: "Tom Cruise",
          spend: "May 26, 2019",
          clicks: "Normal",
        },
        {
          user: "UK_brand_DT_campaign",
          name: "Tom Cruise",
          spend: "May 26, 2019",
          clicks: "Low",
        },
        {
          user: "UK_brand_DT_campaign",
          name: "Tom Cruise",
          spend: "May 26, 2019",
          clicks: "Low",
        },
        {
          user: "UK_brand_DT_campaign",
          name: "Tom Cruise",
          spend: "May 26, 2019",
          clicks: "Low",
        },
        {
          user: "UK_brand_DT_campaign",
          name: "Tom Cruise",
          spend: "May 26, 2019",
          clicks: "High",
        },
        {
          user: "UK_brand_DT_campaign",
          name: "Tom Cruise",
          spend: "May 26, 2019",
          clicks: "High",
        },
      ],
    };
  },
};
</script>

<style scoped>
.rooms {
  padding: 20px;
}
.header {
  padding: 20px;
}
.report-table {
  width: 99%;
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
.bold {
  font-weight: bold;
  color: black;
}
.users-container {
  border: 1px solid #00000021;
  border-radius: 8px;
}
.flexed {
  display: flex;
  align-items: center;
}
.activity{
  border: 1px solid red;
  border-radius: 100px;
  width: 50px;
  background-color: #F12B2C;
  color: white;
  padding: 5px;
  text-align: center;
}
</style>
