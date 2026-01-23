<script lang="ts" setup>
import ReadingReportList from "~/components/reading-passport/ReadingReportList.vue";

const route = useRoute();

const readingResource = ref({
  id: route.params.slug,
  title: "Domain Driven Design",
  imageUrl:
    "https://cdn.kobo.com/book-images/83ac75af-cf9c-4af6-8675-66d28f321213/1200/1200/False/domain-driven-design.jpg",
  totalPages: 180,
  totalReadPages: 45,
  type: "book" as "book" | "journal",
});
</script>

<template>
  <!-- TODO: Adjust spacing on the page -->
  <div class="flex flex-col items-center justify-center gap-4 h-full">
    <UContainer class="flex flex-col gap-y-4" :ui="{ root: 'px-0 mx-[-30px]' }">
      <!-- TODO: Style below card to follow figma design -->
      <UCard
        class="overflow-visible mb-[100px]"
        :ui="{
          header: ' border-0',
          root: 'bg-[#265FC4] mx-[-16px] sm:mx-[-24px] lg:mx-[-32px] rounded-t-none rounded-b-3xl px-4 py-4',
        }"
      >
        <template #header>
          <div class="flex items-start justify-between gap-2">
            <UPageHeader
              :title="readingResource.title"
              :ui="{
                root: 'py-0 border-0 pb-16',
                title:
                  'text-white  line-clamp-3 self-start max-w-[90%] text-[32px] leading-tight',
              }"
              class="flex-1 border-0"
            />

            <UPopover>
              <UButton
                color="white"
                variant="ghost"
                size="xl"
                icon="i-heroicons-ellipsis-vertical"
                class="text-white hover:bg-white/10"
              />

              <template #content>
                <Placeholder class="size-48 m-4 inline-flex" />
              </template>
            </UPopover>
          </div>
        </template>

        <template #footer>
          <div
            class="flex flex-row justify-between relative overflow-visible border-0 ring-0 text-white"
          >
            <img
              :src="readingResource.imageUrl"
              :alt="`${readingResource.title} Cover`"
              class="h-48 md:h-60 aspect-2/3 rounded-2xl absolute -top-12"
            />
            <div />
            <p class="text-right leading-tight font-medium text-[20px]">
              {{ readingResource.totalReadPages }}/{{
                readingResource.totalPages
              }}
              <br />
              Pages Read
            </p>
          </div>
        </template>
      </UCard>
      <!-- TODO: Style below infographic to follow figma design -->
      <div class="grid grid-cols-2 lg:grid-cols-4 gap-4 my-[15px]">
        <UCard>
          <div class="flex flex-row gap-x-2">
            <nuxt-icon name="users" class="text-[38px]" />
            <div class="flex flex-col items-start">
              <p class="font-semibold">Author</p>
              <p class="text-sm text-gray-500">Eric Evans</p>
            </div>
          </div>
        </UCard>

        <UCard>
          <div class="flex flex-row gap-x-2">
            <nuxt-icon name="reading" class="text-[38px]" />
            <div class="flex flex-col items-start">
              <p class="font-semibold">Publish Year</p>
              <p class="text-sm text-gray-500">2003</p>
            </div>
          </div>
        </UCard>

        <UCard>
          <div class="flex flex-row gap-x-2">
            <nuxt-icon name="reading" class="text-[38px]" />
            <div class="flex flex-col items-start">
              <p class="font-semibold">ISBN</p>
              <p class="text-sm text-gray-500">102973049123</p>
            </div>
          </div>
        </UCard>

        <UCard>
          <div class="flex flex-row gap-x-2">
            <nuxt-icon name="reading" class="text-[38px]" />
            <div class="flex flex-col items-start">
              <p class="font-semibold">Category</p>
              <p class="text-sm text-gray-500">Kaulah</p>
            </div>
          </div>
        </UCard>
      </div>

      <!-- TODO: Style the report reading session button -->
      <UButton class="w-full flex justify-center py-4 bg-[#265FC4]">
        <nuxt-icon name="reading" class="text-2xl" />
        Report Reading Session
      </UButton>

      <ReadingReportList />
    </UContainer>
  </div>
</template>
