<script setup lang="ts">
interface WeekDate {
  date: Date;
  day: string;
  isStreak: boolean;
}

defineProps<{
  weekDates: WeekDate[];
}>();
</script>

<template>
  <div
    class="w-full justify-center md:justify-end flex flex-row items-center gap-x-4"
  >
    <div class="fire-wrapper">
      <svg
        class="fire"
        xmlns="http://www.w3.org/2000/svg"
        viewBox="0 0 121.93 156.5"
      >
        <path
          class="fire-back"
          d="m53.57,156.38s-94.25,8.14-32.72-113.18c0,0,2.14,39.45,10.61,33.14C45.44,65.95,21.07,26.52,74.09,0c0,0-7.42,42.33,21.82,72,0,0-3.05-21.82,19.2-36.22,0,0-14.4,21.82.87,53.68,7.23,15.08,22.68,66.92-62.41,66.92Z"
        />
        <path
          class="fire-mid"
          d="m42.82,76.59s6.43,6.43,6.03,11.65c0,0,15.67-19.26,15.67-45.59,0,0,31.34,48.41,27.32,84.17,0,0,8.04-2.81,8.84-10.85,0,0,4.42,40.48-36.97,40.48s-48.62-29.68-38.57-44.1c4.73-6.79,22.1-12.05,17.68-35.76Z"
        />
        <path
          class="fire-front"
          d="m68.02,96.64s26.52,52.15-2.87,59.14c-23.05,5.48-29.75-24.01-12.55-36.2,17.2-12.19,15.41-22.94,15.41-22.94Z"
        />
      </svg>
    </div>

    <div>
      <p class="text-fire font-semibold tracking-tight mb-[10px]">
        7 Days Streak. Keep it up!
      </p>
      <div class="flex flex-row gap-x-2 bg-[#F1F1F1] px-4 py-2 rounded-2xl">
        <div v-for="(dateItem, index) in weekDates" :key="index">
          <p class="text-jose">{{ dateItem.day[0] }}</p>
          <nuxt-icon
            :name="dateItem.isStreak ? 'check' : 'no-streak'"
            :filled="false"
            class="text-[20px]"
            :class="dateItem.isStreak ? 'text-fire' : 'text-[#CCCCCC]'"
          />
        </div>
      </div>
    </div>
  </div>
</template>

<style scoped>
.fire-box {
  height: 94px;
  overflow: hidden;
  display: flex;
  align-items: flex-end;
}

/* 🔥 SATU BADAN */
.fire {
  height: 110px;
  transform-origin: center bottom;
  animation: fireBody 1.4s ease-in-out infinite;
}

/* DETAIL SAJA */
.fire-back {
  fill: #f15b24;
  animation: fireScaleBack 1.8s ease-in-out infinite;
}

.fire-mid {
  fill: #f78d29;
  animation: fireScaleMid 1.5s ease-in-out infinite;
}

.fire-front {
  fill: #fcee23;
  animation: fireScaleFront 1.2s ease-in-out infinite;
}

/* BODY BOUNCE */
@keyframes fireBody {
  0% {
    transform: translateY(0);
  }
  50% {
    transform: translateY(-4px);
  }
  100% {
    transform: translateY(0);
  }
}

/* MICRO FLICKER */
@keyframes fireScaleBack {
  0%,
  100% {
    transform: scaleY(1);
  }
  50% {
    transform: scaleY(1.04);
  }
}

@keyframes fireScaleMid {
  0%,
  100% {
    transform: scaleY(1);
  }
  50% {
    transform: scaleY(1.07);
  }
}

@keyframes fireScaleFront {
  0%,
  100% {
    transform: scale(1);
  }
  50% {
    transform: scale(1.1, 0.95);
  }
}
</style>
