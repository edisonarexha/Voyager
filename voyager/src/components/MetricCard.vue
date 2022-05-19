<template>
  <div>
    <el-card shadow="always">
      <div class="metric-card">
        <span v-if="valueType == 'number'" class="value">{{value}}</span>
        <!-- <span v-if="valueType == 'amount'" class="value">$</span> -->
        <div>

        <span class="name">{{name}}</span>
        </div>
      </div>
    </el-card>
  </div>
</template>

<script>
export default {
    props: ['name', 'value', 'valueType']
};
</script>

<style lang="scss" scoped>
// @import "@/assets/style/css_vars";
.metric-card {
    display: flex;
    flex-direction: column;
    align-items: center;
    justify-content: center;
    height: 100px;

    .value {
        padding: 5px;
        margin-bottom: 10px;
        font-weight: bold;
        font-size: 2rem;
        // color: $app-color;
    }

    .name{
        padding: 5px;
        font-size: 16px;
        font-weight: 300; 

    }
}
</style>