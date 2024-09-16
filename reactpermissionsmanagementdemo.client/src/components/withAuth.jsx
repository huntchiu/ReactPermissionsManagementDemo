import React, { useState, useEffect } from "react";
import { Navigate } from "react-router-dom";

export default function withAuth(Component, policies = {}) {
  return function AuthenticatedComponent(props) {
    const [isAuthenticated, setIsAuthenticated] = useState(null);

    useEffect(() => {
      // 從後端獲取身份驗證狀態
      async function checkAuth() {
        try {
          const response = await fetch("/api/account/isAuthenticated");
          const data = await response.json();
          setIsAuthenticated(data.isAuthenticated);
        } catch (error) {
          console.error("Error checking authentication:", error);
          setIsAuthenticated(false);
        }
      }

      checkAuth();
    }, []);

    if (!isAuthenticated) {
      return <Navigate to="/login" />;
    }

    return <Component {...props} />;
  };
}
