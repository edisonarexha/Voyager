<template>
  <div>
    <el-row :gutter="12">
      <el-col :xl="6" :lg="6" :md="6" :sm="8" :xs="12" >
        <div style="height: 100px">
        <metric-card name="Guests" :value="metrics.guests" valueType="number" />
        </div>
      </el-col>
      <el-col :xl="6" :lg="6" :md="6" :sm="8" :xs="12">
        <metric-card name="Check In" :value="metrics.checkIn" valueType="number"/>
      </el-col>
      <el-col :xl="6" :lg="6" :md="6" :sm="8" :xs="12">
        <metric-card name="Checking Out" :value="metrics.checkingOut" valueType="number"/>
      </el-col>
      <el-col :xl="6" :lg="6" :md="6" :sm="8" :xs="12">
        <metric-card name="Pay Check" :value="metrics.payCheck" valueType="number"/>
      </el-col>
    </el-row>
  </div>
</template>

<script>
import MetricCard from '@/components/MetricCard.vue';

export default {
  components: { MetricCard },
    props: ['metrics'],
};
</script>

<style lang="scss" scoped>

</style>