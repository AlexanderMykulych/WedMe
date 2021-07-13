import { ApolloClient, InMemoryCache } from '@apollo/client/core';
// HTTP connection to the API

// Cache implementation
const cache = new InMemoryCache()

// Create the apollo client
export const apolloClient = new ApolloClient({
    uri: "http://localhost:3000/graphql",
    cache
})