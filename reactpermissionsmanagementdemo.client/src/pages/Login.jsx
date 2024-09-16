import React, { useState } from "react";
import {
  Box,
  Button,
  FormControl,
  FormLabel,
  Input,
  VStack,
  Heading,
  Text,
  Center,
} from "@chakra-ui/react";

export default function () {
  const [email, setEmail] = useState("");
  const [password, setPassword] = useState("");

  const handleSubmit = (e) => {
    e.preventDefault();
    // 在這裡處理登錄邏輯
    console.log("Email:", email);
    console.log("Password:", password);
  };

  return (
    <Center h="100vh">
      <Box p={8} maxW="400px" borderWidth={1} borderRadius={8} boxShadow="lg">
        <VStack spacing={4} align="stretch">
          <Heading size="md">登錄</Heading>
          <form onSubmit={handleSubmit}>
            <FormControl id="email">
              <FormLabel>電子郵件</FormLabel>
              <Input
                type="email"
                value={email}
                onChange={(e) => setEmail(e.target.value)}
                required
              />
            </FormControl>
            <FormControl id="password">
              <FormLabel>密碼</FormLabel>
              <Input
                type="password"
                value={password}
                onChange={(e) => setPassword(e.target.value)}
                required
              />
            </FormControl>
            <Button type="submit" colorScheme="teal" mt={4}>
              登錄
            </Button>
          </form>
          <Text textAlign="center">
            還沒有帳號？<a href="/register">註冊</a>
          </Text>
        </VStack>
      </Box>
    </Center>
  );
}
