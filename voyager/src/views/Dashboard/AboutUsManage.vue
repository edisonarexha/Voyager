<template>
  <div class="rooms">
    <side-bar></side-bar>
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
              <el-form-item label="Title">
                <el-input
                  :disabled="true"
                  v-model="this.aboutData.description"
                  autocomplete="off"
                  placeholder="Title"
                  class="input"
                ></el-input>
              </el-form-item>
              <el-form-item label="Description">
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
            <h6 style="font-size: 20px">Team Members</h6>
            <el-button type="primary" @click="openDialog('fromCreateEvent')"
              >New</el-button
            >
          </div>
          <table class="table mt-3" style="margin-top: 0px; position: inherit">
            <thead>
              <th class="name-width"></th>
              <th class="name-width">Name</th>
              <th class="fields-width">Job Name</th>
              <th class="fields-width">Job Description</th>
              <th class="fields-width text-center">Image</th>
              <th class="text-center">Edit/Delete</th>
            </thead>
            <tbody>
              <tr v-for="(item, index) in teamMembersData" :key="index">
                <td class="name-width members__data">{{ index + 1 }}</td>
                <td class="name-width members__data">{{ item.name }}</td>
                <td class="fields-width members__data">{{ item.jobName }}</td>
                <td class="fields-width members__data">
                  {{ item.jobDescription }}
                </td>

                <td
                  v-if="item.photo"
                  class="fields-width member__image members__data"
                >
                  <img :src="require(`@/assets/teamMembers/${item.photo}`)" />
                </td>
                <td style="text-align: -webkit-center; vertical-align: middle">
                  <div class="flexed" style="width: 40px">
                    <i
                      class="el-icon-edit pointer members__button-edit"
                      @click="openDialog('fromEditEvent', item)"
                    ></i>
                    <i
                      class="el-icon-delete pointer members__button-delete"
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
        <el-dialog :visible.sync="dialogFormVisible" @close="clearError">
          <p class="text-danger error__style">
            {{ error.length ? error : "" }}
          </p>
          <el-form :model="form">
            <el-form-item label="Title" v-if="!this.aboutData">
              <el-input
                v-model="about.description"
                autocomplete="off"
                placeholder="Title"
                class="input"
              ></el-input>
            </el-form-item>
            <el-form-item label="Title" v-else>
              <el-input
                v-model="aboutData.description"
                autocomplete="off"
                placeholder="Title"
                class="input"
              ></el-input>
            </el-form-item>
            <el-form-item v-if="!this.aboutData" label="Description">
              <el-input
                v-model="about.descriptionSecond"
                autocomplete="off"
                placeholder="Description"
                type="textarea"
                class="input"
                rows="5"
              ></el-input>
            </el-form-item>
            <el-form-item label="Description" v-else>
              <el-input
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
          <el-form :model="member">
            <el-form-item>
              <el-input
                v-model="member.name"
                autocomplete="off"
                placeholder="Name"
                class="input"
              ></el-input>
            </el-form-item>
            <el-form-item>
              <el-input
                v-model="member.jobName"
                autocomplete="off"
                placeholder="Job Name"
                class="input"
              ></el-input>
            </el-form-item>
            <el-form-item>
              <el-input
                v-model="member.jobDescription"
                autocomplete="off"
                placeholder="Job Description"
                type="textarea"
                class="input"
                rows="5"
              ></el-input>
            </el-form-item>
            <el-form-item>
              <el-upload
              v-model="fileList"
                action="https://run.mocky.io/v3/9d059bf9-4660-45f2-925d-ce80ad6c4d15"
                list-type="picture-card"
                ref="upload"
                :on-preview="handlePictureCardPreview"
                :on-remove="handleRemove"
                :on-change="changeFileList"
                accept=".jpg, .png, .jpeg"
                :limit="1"
                :auto-upload="false"
                :file-list="fileList"
                :show-file-list="true"
              >
                <i class="el-icon-plus"></i>
              </el-upload>
              <el-dialog :visible.sync="dialogVisible">
                <img width="100%" :src="dialogImageUrl" alt="" />
              </el-dialog>
            </el-form-item>
          </el-form>
          <span slot="footer" class="dialog-footer">
            <el-button :disabled="(!member.name.length || !member.jobName.length || !member.jobDescription.length || !member.photo.length) ? true : false"  type="primary" @click="save()">Done</el-button>
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
import {
  getAllTeamMembers,
  createTeamMember,
  deleteTeamMember,
  updateTeamMember,
} from "../../sdk/teamMembers";
export default {
  components: { SideBar },
  data() {
    return {
      img:'',
      fileList: [],
      member: {
        id: "",
        name: "",
        jobName: "",
        jobDescription: "",
        photo: "",
      },
      teamMembersData: [],
      error: "",
      dialogFormVisible: false,
      teamMembersDialog: false,
      aboutData: [],
      about: {
        descriptionSecond: "",
        description: "",
      },
      form: {},
      // formLabelWidth: '120px',
      dialogImageUrl: "",
      dialogVisible: false,
      multipleSelection: [],
      status: null,
    };
  },
  mounted() {
    this.getAboutUs();
    this.getData();
  },
  methods: {
    changeFileList(file) {
      this.dialogImageUrl = file.url;
      this.member.photo = file.name;
      this.fileList = this.$refs.upload.uploadFiles;
      if (this.fileList.length === 2) this.fileList.splice(0, 1);
    },
    openDialog(field, item) {
      if (field === "fromEditEvent") {
        this.status = field;
        this.teamMembersDialog = true;
        this.img = item.photo
        this.member = {
          id: item.id,
          name: item.name,
          jobName: item.jobName,
          jobDescription: item.jobDescription,
          photo: item.photo,
        };
      } else {
        this.status = field;
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
      await getAllTeamMembers().then((res) => {
        this.teamMembersData = res.data;
      });
    },
    async deleteMember(member) {
      await deleteTeamMember(member).then(() => {
        this.getData();
      });
      this.successDeleteMember();
    },
    async createMember() {
      await createTeamMember(this.member).then(() => {
        this.teamMembersDialog = false;
        this.getData();
      });
      this.successAddMember();
      this.member = {
        name: '',
        photo: '',
        jobName:'',
        jobDescription:''
      }
    },
    async updateMember() {
      await updateTeamMember(this.member).then(() => {
        this.teamMembersDialog = false;
        this.getData();
      });
      this.successEditMember();
    },
    save() {
      if (this.status === "fromEditEvent") {
        this.updateMember();
      } else {
        this.createMember();
      }
    },
    successAbout() {
      this.$toast.success("About has been updated succesfully");
    },
    failAbout() {
      this.$toast.error("Server Error!!");
    },
    successAddMember() {
      this.$toast.success("Member has been added succesfully");
    },
    successEditMember() {
      this.$toast.success("Member has been updated succesfully");
    },
    successDeleteMember() {
      this.$toast.success("Member has been deleted succesfully");
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
    handlePictureCardPreview() {
      this.dialogVisible = true;
    },
  },
};
</script>

<style lang="scss" scoped>
.pointer {
  cursor: pointer;
}
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
  width: 80%;
  padding: 20px;
}
.header {
  padding: 20px;
}
.report-table {
  border: 1px solid #00000021;
  border-radius: 8px;
  width: 100%;
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
.table {
  margin-top: 1rem;
  font-size: 14px;

  .check {
    padding: 10px;
    width: 30px;
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
    }
  }

  .sort-icon-asc-desc {
    display: inline-flex;
    flex-direction: column;
    align-items: center;
    height: 24px;
    // width: 24px;
    vertical-align: middle;
    cursor: pointer;
    overflow: initial;
    position: relative;
    .sort-caret {
      width: 0;
      height: 0;
      border: 5px solid transparent;
      position: absolute;
      left: 4px;
      // border-bottom-color: #409EFF;
    }
    .ascending {
      border-bottom-color: #c0c4cc;
    }
    .descending {
      border-top-color: #c0c4cc;
      bottom: 2px;
    }

    .sorted-field-ascending {
      border-bottom-color: #409eff;
    }

    .sorted-field-descending {
      border-top-color: #409eff;
      bottom: 2px;
    }
  }

  .table-row {
    display: flex;

    .row-item {
      flex: 1;
      padding: 10px;
      text-align: left;
    }

    &:nth-of-type(even) {
      background-color: #f1f1f1;
    }
  }
}

.member__image {
  width: 150px;
}

.members__data {
  vertical-align: middle;
  font-size: 18px;
  font-family: "Open Sans", sans-serif;
}

.members__button-delete {
  color: red;
  font-size: 25px;
  margin-left: 10px;
  opacity: 0.6;
}

.members__button-edit {
  font-size: 25px;
  // margin-left:20px;
  vertical-align: middle;
  opacity: 0.6;
}
.members__button-edit:hover,
.members__button-delete:hover {
  opacity: 1;
}
</style>
