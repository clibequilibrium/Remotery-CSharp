cmake_minimum_required(VERSION 3.16)

project(Remotery C)
set(CMAKE_C_STANDARD 11)

include_directories(Remotery PRIVATE include)

add_library(Remotery SHARED lib/Remotery.c lib/Remotery.h) 
target_compile_definitions(Remotery PUBLIC RMT_DLL=1)