<script setup lang="ts">
import { ref } from "vue";
import ReadingRecomendation from "./ReadingRecomendation.vue";
import { Swiper, SwiperSlide } from "swiper/vue";

// Import Swiper styles
import "swiper/css";
import "swiper/css/pagination";

import { Pagination } from "swiper/modules";

const books = ref([
  {
    title: "Domain Driven Design",
    imageUrl: "https://picsum.photos/seed/report1/400/600",
    category: "Programming",
    author: "Eric Evans",
    totalPage: 180,
    xp: 30,
  },
  {
    title: "Clean Code",
    imageUrl: "https://picsum.photos/seed/report2/400/600",
    category: "Software Engineering",
    author: "Robert C. Martin",
    totalPage: 250,
    xp: 30,
  },
  {
    title: "The Pragmatic Programmer",
    imageUrl: "https://picsum.photos/seed/report3/400/600",
    category: "Software Development",
    author: "Andrew Hunt & David Thomas",
    totalPage: 320,
    xp: 30,
  },
  {
    title: "Refactoring",
    imageUrl: "https://picsum.photos/seed/report4/400/600",
    category: "Programming",
    author: "Martin Fowler",
    totalPage: 290,
    xp: 30,
  },
]);

const modules = [Pagination];
</script>

<template>
  <div>
    <div>
      <h1 class="font-semibold text-[20px] tracking-tight">
        Don’t know what to read?
      </h1>
      <h6 class="text-[16px] tracking-tight mb-[20px]">
        We have recommendations
      </h6>
    </div>

    <!-- Swiper Carousel -->
    <swiper
      :spaceBetween="12"
      :pagination="{ clickable: true }"
      :modules="modules"
      :breakpoints="{
        0: {
          slidesPerView: 2,
        },
        640: {
          slidesPerView: 3,
        },
        768: {
          slidesPerView: 3,
        },
        1024: {
          slidesPerView: 4,
        },
      }"
      class="mb-8"
    >
      <swiper-slide v-for="(book, index) in books" :key="index">
        <ReadingRecomendation :book="book" />
      </swiper-slide>
    </swiper>

    <!-- List Bawah -->
    <!-- <div class="flex flex-col gap-y-4">
      <ReadingRecomendation
        v-for="(book, index) in books"
        :key="index"
        :book="book"
      />
    </div> -->
  </div>
</template>
