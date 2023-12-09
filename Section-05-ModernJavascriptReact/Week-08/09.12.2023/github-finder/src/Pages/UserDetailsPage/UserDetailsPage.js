import React, { useContext, useEffect } from 'react'
import { useParams } from 'react-router-dom'
import { AppContext } from '../../Contexts/AppContext';
import { Card, CardBody, CardHeader, CardTitle, Col, Container, ListGroup, Row } from 'react-bootstrap';
import UserRepo from '../../Components/UserRepo';

const UserDetailsPage = () => {
    const context = useContext(AppContext)
    const { login } = useParams();
    useEffect(() => {
        context.getUser(login);
        context.getRepos(login);
    }, [])
    return (
        <>
            <Container className='w-75 my-3'>
                <Card>
                    <Row>
                        <Col xs={12}>
                            <CardHeader className='display-6 text-danger'>
                                {context.user.name} ({context.user.login})
                            </CardHeader>
                        </Col>
                    </Row>
                    <Row>
                        <Col xs={4}>
                            <Row>
                                <Col>
                                    <Card.Img className='' src={context.user.avatar_url} />
                                </Col>
                            </Row>
                            <Row>
                                <Col>
                                    <CardBody>
                                        <CardTitle>Followers: </CardTitle><div className='mb-2'>{context.user.followers}</div>
                                        <CardTitle>Following: </CardTitle><div className='mb-2'>{context.user.following}</div>
                                    </CardBody>
                                </Col>
                            </Row>
                        </Col>
                        <Col xs={8}>
                            <Row>
                                <Col xs={12}>
                                    <Card.Body>
                                        <ListGroup className='flex-row flex-wrap justify-content-start'>
                                            {context.userRepos.map(userRepo => <UserRepo key={userRepo.id} userRepoName={userRepo.name} userRepoUrl={userRepo.html_url} />)}
                                        </ListGroup>
                                    </Card.Body>
                                </Col>
                            </Row>
                        </Col>
                    </Row>
                </Card>
            </Container>
        </>
    )
}

export default UserDetailsPage