<template>
  <img alt="Vue logo" src="./assets/logo.png" />
  {{loading}}
  {{result?.contact}}
</template>

<script lang="ts">
import gql from 'graphql-tag';
import { watch } from 'vue'
import HelloWorld from './components/HelloWorld.vue'
import { useQuery } from '@vue/apollo-composable'

export default {
  name: 'App',
  components: {
    HelloWorld
  },
  setup () {
    const {result, loading} = useQuery(gql`
      query getContact {
        contact {
         id
         name   
         createdOn
        }
      }
    `)
    watch(result.value, val => {
      console.log(val)
    })
    return {
        contacts: [],
        result,
        loading
    }
  }
}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
