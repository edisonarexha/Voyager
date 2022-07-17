<template>
  <div class="rooms">
    <side-bar :sidebar-item-color="sidebarBackground"></side-bar>
    <div class="form-max-width">
      <h4>Voyager Dashboard</h4>
      <div class="third-container">
        <div class="report-table">
          <div class="flexed">
            <h6 style="font-size: 20px">Manage About Us</h6>
            <el-button type="primary" @click="dialogFormVisible = true">{{
              this.aboutData ? "Modify" : "Add"
            }}</el-button>
          </div>
          <div class="mt-2">
            <el-form :model="form">
              <el-form-item :label-width="formLabelWidth">
                <el-input
                  :disabled="true"
                  v-model="this.aboutData.description"
                  autocomplete="off"
                  placeholder="Title"
                  class="input"
                ></el-input>
              </el-form-item>
              <el-form-item :label-width="formLabelWidth">
                <el-input
                  :disabled="true"
                  v-model="this.aboutData.descriptionSecond"
                  autocomplete="off"
                  placeholder="Description"
                  type="textarea"
                  class="input"
                  columns="7"
                  rows="5"
                ></el-input>
              </el-form-item>
            </el-form>
          </div>
        </div>
        <div class="report-table">
          <div class="flexed">
            <h6 style="font-size: 20px">Manage Team Members</h6>
            <el-button type="primary" @click="teamMembersDialog = true"
              >New</el-button
            >
          </div>
          <el-table ref="multipleTable" :data="teamMembersData.data" style="width: 950px">
            <!-- <el-table-column width="120"> -->
              <template slot-scope="scope">
            <!-- </el-table-column>  -->
            <el-table-column type="index"> </el-table-column>
            <el-table-column property="name" width="120"> </el-table-column>
            <el-table-column property="jobName" show-overflow-tooltip>
            </el-table-column>
            <el-table-column property="jobDescription" show-overflow-tooltip>
            </el-table-column>
            <el-table-column property="photo" show-overflow-tooltip>
            </el-table-column>
            <el-table-column
              property="address"
              show-overflow-tooltip
              width="80"
              style="display: flex; gap: 10px"
            >
              <i class="el-icon-edit" style="color: #409eff; font-size:22px; cursor:pointer;" ></i>
              <i class="el-icon-delete" @click="deleteMember($event, scope.row)" style="color: red; font-size:22px; margin-left:15px; cursor:pointer;"></i>
            </el-table-column>
            </template>
          </el-table>
        </div>
      </div>
      <div>
        <el-dialog :visible.sync="dialogFormVisible" @close="clearError">
          <p class="text-danger error__style">
            {{ error.length ? error : "" }}
          </p>
          <el-form :model="form">
            <el-form-item :label-width="formLabelWidth">
              <el-input
                v-if="!this.aboutData"
                v-model="about.description"
                autocomplete="off"
                placeholder="Title"
                class="input"
              ></el-input>
              <el-input
                v-else
                v-model="aboutData.description"
                autocomplete="off"
                placeholder="Title"
                class="input"
              ></el-input>
            </el-form-item>
            <el-form-item :label-width="formLabelWidth">
              <el-input
                v-if="!this.aboutData"
                v-model="about.descriptionSecond"
                autocomplete="off"
                placeholder="Description"
                type="textarea"
                class="input"
                rows="5"
              ></el-input>
              <el-input
                v-else
                v-model="aboutData.descriptionSecond"
                autocomplete="off"
                placeholder="Description"
                type="textarea"
                class="input"
                rows="5"
              ></el-input>
            </el-form-item>
          </el-form>
          <span slot="footer" class="dialog-footer">
            <el-button type="primary" @click="addAboutUs()">Done</el-button>
          </span>
        </el-dialog>
      </div>
      <div>
        <!-- team members -->
        <el-dialog :visible.sync="teamMembersDialog">
          <el-form :model="form">
            <el-form-item :label-width="formLabelWidth">
              <el-input
                v-model="member.name"
                autocomplete="off"
                placeholder="Name"
                class="input"
              ></el-input>
            </el-form-item>
            <el-form-item :label-width="formLabelWidth">
              <el-input
                v-model="member.jobName"
                autocomplete="off"
                placeholder="Job Name"
                class="input"
              ></el-input>
            </el-form-item>
            <el-form-item :label-width="formLabelWidth">
              <el-input
                v-model="member.jobDescription"
                autocomplete="off"
                placeholder="Job Description"
                type="textarea"
                class="input"
                rows="5"
              ></el-input>
            </el-form-item>
            <el-form-item :label-width="formLabelWidth">
              <el-upload
                action="https://jsonplaceholder.typicode.com/posts/"
                list-type="picture-card"
                :on-success="handlePictureGetUrl"
                :on-preview="handlePictureCardPreview"
                :on-remove="handleRemove"
              >
                <i class="el-icon-plus"></i>
              </el-upload>
              <el-dialog :visible.sync="dialogVisible">
                <img width="100%" :src="dialogImageUrl" alt="" />
              </el-dialog>
            </el-form-item>
          </el-form>
          <span slot="footer" class="dialog-footer">
            <el-button type="primary" @click="createMember()"
              >Done</el-button
            >
          </span>
        </el-dialog>
        <!-- Team MEmbers -->
      </div>
    </div>
  </div>
</template>

<script>
import SideBar from "@/components/Dashboard/SidebarPlugin/SideBar.vue";
import { getAboutList, createAbout, editAbout } from "../../sdk/about";
import {getAllTeamMembers, createTeamMember,deleteTeamMember} from "../../sdk/teamMembers"
export default {
  components: { SideBar },
  data() {
    return {
      member:{
        name:'',
        jobName:'',
        jobDescription:'',
        photo:''
      },
      teamMembersData:[],
      error: "",
      dialogFormVisible: false,
      teamMembersDialog: false,
      aboutData: [],
      about: {
        descriptionSecond: "",
        description: "",
      },
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
      // formLabelWidth: '120px',
      tableData: [
        {
          date: "2016-05-03",
          name: "Tom",
          address: "No. 189, Grove St, Los Angeles",
        },
        {
          date: "2016-05-02",
          name: "Tom",
          address: "No. 189, Grove St, Los Angeles",
        },
        {
          date: "2016-05-04",
          name: "Tom",
          address: "No. 189, Grove St, Los Angeles",
        },
        {
          date: "2016-05-01",
          name: "Tom",
          address: "No. 189, Grove St, Los Angeles",
        },
        {
          date: "2016-05-08",
          name: "Tom",
          address: "No. 189, Grove St, Los Angeles",
        },
        {
          date: "2016-05-06",
          name: "Tom",
          address: "No. 189, Grove St, Los Angeles",
        },
        {
          date: "2016-05-07",
          name: "Tom",
          address: "No. 189, Grove St, Los Angeles",
        },
      ],
      dialogImageUrl: "",
      dialogVisible: false,
      multipleSelection: [],
    };
  },
  mounted() {
    this.getAboutUs()
    this.getTeamMembers()
  },
  methods: {
    async getTeamMembers(){
      this.teamMembersData = await getAllTeamMembers()
    },
    async deleteMember(member){
      await deleteTeamMember(member)
    },
    async createMember(){
      await createTeamMember(this.member)
      this.dialogVisible = false
    },
    successAbout() {
      this.$toast.success("About has been updated succesfully", {
        position: "top-right",
        timeout: 3000,
        closeOnClick: true,
        pauseOnFocusLoss: true,
        pauseOnHover: true,
        draggable: true,
        draggablePercent: 0.6,
        showCloseButtonOnHover: false,
        hideProgressBar: true,
        closeButton: "button",
        icon: true,
        rtl: false,
      });
    },
    failAbout() {
      this.$toast.error("Server Error!!", {
        position: "top-right",
        timeout: 3000,
        closeOnClick: true,
        pauseOnFocusLoss: true,
        pauseOnHover: true,
        draggable: true,
        draggablePercent: 0.6,
        showCloseButtonOnHover: false,
        hideProgressBar: true,
        closeButton: "button",
        icon: true,
        rtl: false,
      });
    },
    clearError() {
      this.error = "";
    },
    async getAboutUs() {
      const result = await getAboutList();
      this.aboutData = !result.length ? [] : result[0];
    },
    async addAboutUs() {
      if (!this.aboutData) {
        if (
          !this.about.descriptionSecond.trim().length ||
          !this.about.description.trim().length
        ) {
          this.error = "Please fill all the fields!!";
          this.dialogFormVisible = true;
        } else {
          this.error = "";
          await createAbout(this.about);
          this.dialogFormVisible = false;
          this.successAbout();
        }
      } else if (this.aboutData) {
        if (
          !this.aboutData.descriptionSecond.trim().length ||
          !this.aboutData.description.trim().length
        ) {
          this.error = "Please fill all the fields!!";
          this.dialogFormVisible = true;
        } else {
          const obj = {
            descriptionSecond: this.aboutData.descriptionSecond,
            description: this.aboutData.description,
            _id: this.aboutData._id,
          };
          const res = await editAbout(obj);
          this.dialogFormVisible = false;
          if (res.status == 200) {
            this.successAbout();
          } else {
            this.failAbout();
          }
        }
      }
    },
    toggleSelection(rows) {
      if (rows) {
        rows.forEach((row) => {
          this.$refs.multipleTable.toggleRowSelection(row);
        });
      } else {
        this.$refs.multipleTable.clearSelection();
      }
    },
    handleRemove(file, fileList) {
      console.log(file, fileList);
    },
    handlePictureCardPreview(file) {
      this.dialogImageUrl = file.url;
      this.member.photo = file.name
      this.dialogVisible = true;
    },
    handlePictureGetUrl(file){
      console.log(file)
    },
    handleSelectionChange(val) {
      this.multipleSelection = val;
    },
  },
};
</script>

<style scoped>
.rooms {
  /* padding: 20px; */
  display: flex;
  gap: 20px;
  height: 900px;
}
.third-container {
  padding: 20px;
}
.form-max-width {
  max-width: 80%;
  padding: 20px;
}
.header {
  padding: 20px;
}
.report-table {
  border: 1px solid #00000021;
  border-radius: 8px;
  width: 900px;
  /* height: 700px; */
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
.flexed {
  display: flex;
  align-items: center;
  justify-content: space-between;
}
.input {
  width: 100%;
}

.error__style {
  text-align: center;
  font-weight: bold;
  font-size: 18px;
  font-family: "Open Sans", sans-serif;
}
</style>
