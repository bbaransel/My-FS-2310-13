import React from 'react'

function TickTock(props) {
    // const tick = setInterval(() => {
    //     return new Date().toLocaleTimeString();
    // }, 1000);
    return (
        <>
            <h1>Hello React!</h1>
            <h3>First Name: {props.firstName} </h3>
            <h3>Last Name: {props.lastName} </h3>
            <h3>Age: {props.age} </h3>
        </>
    )
}

export default TickTock