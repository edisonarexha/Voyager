<template>
  <div class="rooms">
    <side-bar :sidebar-item-color="sidebarBackground"></side-bar>
    <div class="form-max-width">
    <h4>Voyager Dashboard</h4>
    <div class="users-container">
      <div class="header">
        <h5>Users</h5>
      </div>
      <div>
        <div class="report-table">
          <!-- <div class="flexed" style="justify-content:end; gap:20px">
            <span style="font-size: 15px"> <list-icon size="1.5x" class="custom-class"></list-icon> Sort</span>
            <span style="font-size: 15px"> <filter-icon size="1.5x" class="custom-class"></filter-icon> Filter</span>
          </div> -->

          <table class="table mt-3" style="margin-top: 0px; position: inherit">
            <thead>
              <th class="name-width"></th>
              <th class="name-width">Name</th>
              <th class="fields-width">Last Name</th>
              <th class="fields-width">Email</th>
              <th class="fields-width">Username</th>
            </thead>
            <tbody>
              <tr v-for="(item, index) in users" :key="index">
                <td class="name-width members__data"><el-avatar style="background-color:rgb(55, 81, 255);color:white; font-size:16px;padding-top: 7px;" size="large">{{getFirstCharThirdPartyName(item) }}</el-avatar></td>
                <td class="name-width members__data">{{ item.name }}</td>
                <td class="fields-width members__data">{{ item.lastName }}</td>
                <td class="fields-width members__data"> {{ item.email }}
                <td class="fields-width members__data"> {{ item.userName }}
                </td>
              </tr>
            </tbody>
          </table>
        </div>
      </div>
    </div>
    </div>
    <div>
      <el-dialog :visible.sync="dialogFormVisible">
        <el-form :model="form">
          <div class="flexed">
          <el-form-item :label-width="formLabelWidth">
            <el-input  autocomplete="off" placeholder="Trip Name" class="input"></el-input>
          </el-form-item>
          <el-form-item :label-width="formLabelWidth">
            <el-input  autocomplete="off" placeholder="Place" class="input"></el-input>
          </el-form-item>
          </div>
          <div class="flexed">
            <el-form-item :label-width="formLabelWidth">
            <el-input  autocomplete="off" placeholder="Price" class="input"></el-input>
          </el-form-item>
          <el-form-item :label-width="formLabelWidth">
            <el-input  autocomplete="off" placeholder="Date" class="input"></el-input>
          </el-form-item>
          </div>
          <el-form-item :label-width="formLabelWidth">
            <el-input  autocomplete="off" placeholder="Description" type="textarea" class="input" rows="5"></el-input>
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
import SideBar from '@/components/Dashboard/SidebarPlugin/SideBar.vue';
// import { FilterIcon, ListIcon } from 'vue-feather-icons'
import {
  getAllUsers
} from "@/sdk/users.js";
export default {
   components: {
      SideBar
  },
  data() {
    return {
      dialogFormVisible: false,
      users:[],
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
    }
  },
    beforeMount() {
    this.getData();
  },
    methods:{
      getFirstCharThirdPartyName(item) {
      if (item.name) {
        return item.name.charAt(0).toUpperCase();
      } 
    },
        async getData() {
      await getAllUsers().then((res) => {
        this.users = res.data.sort(item => item.name)
      });
    },

    }
};
</script>

<style lang="scss" scoped>
.pointer {
  cursor: pointer;
}
.rooms {
  /* padding: 20px; */
  display: flex;
  height: 900px;
}
.form-max-width{
  max-width: 80%;
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
.table {
  margin-top: 1rem;
  font-size: 14px;
  width: 1100px;

  .check {
    padding: 10px;
    width: 30px;
  }
  .members__data {
  vertical-align: middle;
  font-size: 16px;
  font-family: "Open Sans", sans-serif;
  padding: 20px;
}

  .table-head {
    display: flex;
    border-bottom: 1px solid #d4d4d4;
    font-weight: bold;
    .head-item {
      flex: 1;
      padding: 10px;
      text-align: left;
      cursor: pointer;
      display: flex;
      align-items: center;

      /*.sort-icon {
        visibility: hidden;
      }

      &:hover {
        .sort-icon {
          visibility: visible;
        }
      }*/
    }}
  }
</style>
