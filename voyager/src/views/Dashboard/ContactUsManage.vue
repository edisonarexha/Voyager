<template>
  <div class="rooms">
    <side-bar :sidebar-item-color="sidebarBackground"></side-bar>
    <div class="form-max-width">
      <h4>Voyager Dashboard</h4>
      <div class="third-container">
        <div class="report-table">
          <div class="flexed">
            <h6 style="font-size: 20px">Manage Contact Us</h6>
            <el-button type="primary" @click="dialogFormVisible = true"
              >Modify</el-button
            >
          </div>
          <div>
            <el-form :model="form" class="flexed-form">
              <div>
                <el-form-item>
                  <el-input
                    v-model="form.name"
                    autocomplete="off"
                    placeholder="Email"
                    class="input"
                  ></el-input>
                </el-form-item>
                <el-form-item>
                  <el-input
                    v-model="form.name"
                    autocomplete="off"
                    placeholder="Phone"
                    type="input"
                    class="input"
                  ></el-input>
                </el-form-item>
              </div>

              <div>
                <el-form-item>
                  <el-input
                    v-model="form.name"
                    autocomplete="off"
                    placeholder="Address"
                    type="input"
                    class="input"
                  ></el-input>
                </el-form-item>
                <el-form-item>
                  <el-input
                    v-model="form.name"
                    autocomplete="off"
                    placeholder="Website"
                    type="input"
                    class="input"
                  ></el-input>
                </el-form-item>
              </div>
            </el-form>
          </div>
        </div>
        <div class="report-table">
          <div class="flexed">
            <h6 style="font-size: 20px">Contact Messages</h6>
          </div>
          <el-table ref="multipleTable" :data="tableData" style="width: 950px">
            <el-table-column property="name" width="120"> </el-table-column>
            <el-table-column property="email" show-overflow-tooltip>
            </el-table-column>
            <el-table-column property="subject" show-overflow-tooltip>
            </el-table-column>
            <el-table-column property="message" show-overflow-tooltip>
            </el-table-column>
          </el-table>
        </div>
      </div>
      <div>
        <el-dialog :visible.sync="dialogFormVisible">
          <el-form :model="form" class="flexed-form">
          <div>
             <el-form-item>
              <el-input
                v-model="form.name"
                autocomplete="off"
                placeholder="Email"
                class="input"
              ></el-input>
            </el-form-item>
            <el-form-item>
              <el-input
                v-model="form.name"
                autocomplete="off"
                placeholder="Address"
                type="input"
                class="input"
              ></el-input>
            </el-form-item>
          </div>
           <div>
            <el-form-item>
              <el-input
                v-model="form.name"
                autocomplete="off"
                placeholder="Phone"
                type="input"
                class="input"
              ></el-input>
            </el-form-item>
            <el-form-item>
              <el-input
                v-model="form.name"
                autocomplete="off"
                placeholder="Website"
                type="input"
                class="input"
              ></el-input>
            </el-form-item>
           </div>
            
          </el-form>
          <span slot="footer" class="dialog-footer">
            <el-button type="primary" @click="dialogFormVisible = false"
              >Done</el-button
            >
          </span>
        </el-dialog>
      </div>
    </div>
  </div>
</template>

<script>
import SideBar from "@/components/Dashboard/SidebarPlugin/SideBar.vue";
export default {
  components: { SideBar },
  data() {
    return {
      dialogFormVisible: false,
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
      tableData: [
        {
          name: "Tom",
          email: "edisona@gmail.com",
          subject: "2016-05-03",
          message: "No. 189, Grove St, Los Angeles",
        },
        {
          name: "Tom",
          email: "edisona@gmail.com",
          subject: "2016-05-03",
          message: "No. 189, Grove St, Los Angeles",
        },
        {
          name: "Tom",
          email: "edisona@gmail.com",
          subject: "2016-05-03",
          message: "No. 189, Grove St, Los Angeles",
        },
      ],
    };
  },
  methods: {
    toggleSelection(rows) {
      if (rows) {
        rows.forEach((row) => {
          this.$refs.multipleTable.toggleRowSelection(row);
        });
      } else {
        this.$refs.multipleTable.clearSelection();
      }
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
.flexed-form {
  display: flex;
  align-items: center;
  gap: 20px;
  justify-content: center;
  padding: 20px;
}
.input {
  width: 300px;
}
</style>
