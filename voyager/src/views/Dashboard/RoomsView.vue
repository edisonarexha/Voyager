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
     
       <table class="table" style="margin-top: 0px; position: inherit">
            <thead>
              <th class="name-width">Name</th>
              <th class="fields-width">Job Name</th>
              <th class="fields-width">Job Description</th>
              <th class="fields-width">Image</th>
            </thead>
            <tbody>
              <tr v-for="(item, index) in rooms" :key="index">
                <td class="name-width">{{ item.name }}</td>
                <td class="fields-width">{{ item.jobName }}</td>
                <td class="fields-width">{{ item.jobDescription }}</td>
                <td class="fields-width">{{ item.photo }}</td>
                <td style="text-align: left">
                  <div class="flexed" style="width: 40px">
                    <i
                      class="el-icon-edit pointer"
                      @click="openDialog('fromEditEvent', item)"
                    ></i>
                    <i
                      class="el-icon-delete pointer"
                      @click="deleteMember(item)"
                    ></i>
                  </div>
                </td>
              </tr>
            </tbody>
          </table>
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
import {
  getHotelRooms,
  createHotelRoom,
  deleteHotelRoom,
  updateHotelRoom
} from "../../sdk/teamMembers";
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
      rooms:[],
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
  }
},
 mounted() {
    this.getData();
  },
  methods: {
    openDialog(field, item) {
      if (field === "fromEditEvent") {
        this.status = field
        this.teamMembersDialog = true;
        this.member = {
          id: item.id,
          name: item.name,
          jobName: item.jobName,
          jobDescription: item.jobDescription,
          photo: item.photo,
        };
      } else {
        this.status = field
        this.teamMembersDialog = true;
        this.member = {
          name: "",
          jobName: "",
          jobDescription: "",
          photo: "",
        };
      }
    },
    async getData() {
      await getHotelRooms().then((res) => {
        this.rooms = res.data;
      });
    },
    async deleteRoom(member) {
      await deleteHotelRoom(member).then(() => {
        this.getData();
      });
    },
    async createRoom() {
      await createHotelRoom(this.member).then(() => {
        this.teamMembersDialog = false;
        this.getData();
      });
    },
    async updateRoom() {
      await updateHotelRoom(this.member).then(() => {
        this.teamMembersDialog = false;
        this.getData();
      });
    },
    save(){
      if(this.status === "fromEditEvent"){
        this.updateMember()
      }else{
        this.createMember()
      }
    },
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